using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormLogin : Form
    {
        // Variável usada para acessar os dados do banco de dados.
		
		private readonly Connection connection = new Connection(); 

		// Inicializa os componentes da tela de Login.
		
        public FormLogin()
        {
            InitializeComponent(); 
        }
		
		// Verifica se o usuário inseriu seu nome de usuário e senha. Se o usuário não inseriu seu nome de usuário ou senha, o código 
		// exibirá uma mensagem de erro ao usuário e retornará. Após o preenchimento do "nome" e "senha", será aberta uma conexão e 
		// criado um comando SQL para selecionar todos os registros da tabela "tbl_Login" onde o nome de usuário e a senha correspondam 
		// aos valores inseridos pelo usuário. Se as credenciais forem válidas, o código abrirá o formulário principal. 
		// Se as credenciais não forem válidas, o código exibirá uma mensagem de erro ao usuário.

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Por favor insira seu usuário e senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; 
            }

            try
            {
                using (SqlConnection con = connection.ReturnConnection())
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con))
                {
                    cmd.Parameters.AddWithValue("@username", txbNome.Text);
                    cmd.Parameters.AddWithValue("@password", txbSenha.Text);
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
    }
}