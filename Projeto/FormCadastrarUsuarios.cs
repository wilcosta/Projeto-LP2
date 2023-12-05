using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormCadastrarUsuarios : Form
    {
        private readonly Connection connection;

        public FormCadastrarUsuarios(Connection connection)
        {
            this.connection = connection ?? throw new ArgumentNullException(nameof(connection));
            InitializeComponent();
        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                // Verifica se o usuário já existe
                using (SqlConnection con = connection.ReturnConnection())
                using (SqlCommand cmdVerificar = new SqlCommand("SELECT COUNT(*) FROM tbl_Login WHERE UserName=@username", con))
                {
                    cmdVerificar.Parameters.AddWithValue("@username", txbNome.Text);
                    con.Open();
                    int usuarioExistente = (int)cmdVerificar.ExecuteScalar();

                    if (usuarioExistente > 0)
                    {
                        MessageBox.Show("Usuário já existe. Escolha outro nome de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                // Insere o novo usuário com o nome de usuário e a senha criptografados em SHA-256
                string nomeUsuarioCriptografado = CriptografarSHA256(txbNome.Text);
                string senhaCriptografada = CriptografarSHA256(txbSenha.Text);

                using (SqlConnection con = connection.ReturnConnection())
                using (SqlCommand cmdInserir = new SqlCommand("INSERT INTO tbl_Login (username, password) VALUES (@username, @password)", con))
                {
                    cmdInserir.Parameters.AddWithValue("@username", nomeUsuarioCriptografado);
                    cmdInserir.Parameters.AddWithValue("@password", senhaCriptografada);

                    con.Open();
                    cmdInserir.ExecuteNonQuery();
                }

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private string CriptografarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}