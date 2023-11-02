using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormLogin : Form
    {
        private readonly Connection connection = new Connection(); // Cria uma instância da classe Connection para gerenciar a conexão com o banco de dados.

        public FormLogin()
        {
            InitializeComponent(); // Inicializa o formulário.
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Por favor insira seu usuário e senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Verifica se os campos de usuário e senha estão vazios e exibe uma mensagem de erro.
            }

            try
            {
                using (SqlConnection con = connection.ReturnConnection()) // Cria uma conexão com o banco de dados usando a classe Connection.
                using (SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con))
                {
                    cmd.Parameters.AddWithValue("@username", txbNome.Text); // Define os parâmetros @username e @password na consulta SQL.
                    cmd.Parameters.AddWithValue("@password", txbSenha.Text);
                    con.Open(); // Abre a conexão com o banco de dados.
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds); // Executa a consulta SQL e preenche um DataSet.

                    int count = ds.Tables[0].Rows.Count; // Obtém o número de linhas retornadas pela consulta.

                    if (count == 1)
                    {
                        // Obter o nome de usuário autenticado
                        string nomeDoUsuario = txbNome.Text;

                        this.Hide(); // Oculta o formulário de login.
                        FormPrincipal fm = new FormPrincipal(nomeDoUsuario); // Passe o nome do usuário para o FormPrincipal
                        fm.Show(); // Exibe o formulário principal.
                    }
                    else
                    {
                        MessageBox.Show("Acesso Negado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        // Limpa os campos após acesso negado
                        txbNome.Clear(); // Limpa o campo de nome de usuário.
                        txbSenha.Clear(); // Limpa o campo de senha.
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message); // Trata exceções e exibe mensagens de erro, se houverem.
            }
        }
    }
}