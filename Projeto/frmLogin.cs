using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent(); 
        }

        string cs = "Data Source=DESKTOP-DELL\\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True;";
        // A string "cs" armazena a cadeia de conexão para o banco de dados SQL.

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txbUserName.Text == "" || txbPassword.Text == "")
            {
                MessageBox.Show("Por favor insira seu usuário e senha");  // Exibe uma mensagem se os campos de usuário ou senha estiverem vazios.
                return;  
            }
            try
            {
                // Conexão SQL
                SqlConnection con = new SqlConnection(cs);  // Cria uma conexão com o banco de dados usando a string de conexão.
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con);
                
                // Cria um comando SQL para selecionar dados da tabela "tbl_Login" com base no nome de usuário e senha.
                cmd.Parameters.AddWithValue("@username", txbUserName.Text);  // Define parâmetros para o nome de usuário.
                cmd.Parameters.AddWithValue("@password", txbPassword.Text);  // Define parâmetros para a senha.
               
                con.Open();  // Abre a conexão com o banco de dados.
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
               
                con.Close();  // Fecha a conexão com o banco de dados.
                int count = ds.Tables[0].Rows.Count;
                
                // Verificação para mostrar o formulário frmMain
                if (count == 1)
                {
                    MessageBox.Show("Login efetuado com sucesso!"); 
                    this.Hide();  // Esconde o formulário atual (frmLogin).
                    frmMain fm = new frmMain();  // Cria uma instância do formulário principal (frmMain).
                    fm.Show();  // Exibe o formulário principal.
                }
                else
                {
                    MessageBox.Show("Falha no login!");  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
    }
}