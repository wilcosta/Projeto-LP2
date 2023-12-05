using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System;

namespace Projeto
{
    public partial class FormLogin : Form
    {
        private readonly Connection connection = new Connection();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNome.Text) || string.IsNullOrEmpty(txbSenha.Text))
            {
                MessageBox.Show("Por favor insira seu usuário e senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                string nomeUsuarioCriptografado = CriptografarSHA256(txbNome.Text);
                string senhaCriptografada = CriptografarSHA256(txbSenha.Text);

                using (SqlConnection con = connection.ReturnConnection())
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Login WHERE UserName=@username AND Password=@password", con))
                {
                    cmd.Parameters.AddWithValue("@username", nomeUsuarioCriptografado);
                    cmd.Parameters.AddWithValue("@password", senhaCriptografada);
                    con.Open();

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        string nomeDoUsuario = txbNome.Text;

                        this.Hide();
                        FormPrincipal fm = new FormPrincipal(nomeDoUsuario);
                        fm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Acesso Negado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txbNome.Clear();
                        txbSenha.Clear();
                    }
                }
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
