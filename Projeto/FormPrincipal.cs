using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            AtualizarListView(); // Carregue a ListView no início do formulário
            btnEditar.Enabled = false; // Desabilita o botão "Detalhar" no início
            btnExcluir.Enabled = false; // Desabilita o botão "Excluir" no início
        }

        // Método para atualizar a ListView com os dados do banco de dados
        public void AtualizarListView()
        {
            ltvFormPrincipal.Items.Clear();

            using (Connection connection = new Connection())
            {
                using (SqlConnection con = connection.OpenConnection())
                {
                    try
                    {
                        string sql = "SELECT Codigo, Descricao, CodigoBarra, Unidade, Quantidade, DataVencimento, DiasRestantes, Observacao FROM tbl_ControleVenc";

                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            SqlDataReader reader = command.ExecuteReader();

                            // Preencha a ListView com os dados do banco de dados
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["Codigo"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["CodigoBarra"].ToString());
                                item.SubItems.Add(reader["Unidade"].ToString());
                                item.SubItems.Add(reader["Quantidade"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataVencimento"]).ToShortDateString());
                                item.SubItems.Add(reader["DiasRestantes"].ToString());
                                item.SubItems.Add(reader["Observacao"].ToString());

                                ltvFormPrincipal.Items.Add(item);
                            }

                            reader.Close();
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erro ao carregar registros do banco de dados: " + err.Message);
                    }
                }
            }
        }

        private void BtnAlterarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Abre o formulário de cadastro
            FormCadastro formCad = new FormCadastro(this);
            formCad.ShowDialog();
        }

        private void LtvFormPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ltvFormPrincipal.SelectedItems.Count > 0)
            {
                // Habilita os botões "Detalhar" e "Excluir" quando um item é clicado duas vezes
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void BtnDetalhar_Click(object sender, EventArgs e)
        {
            if (ltvFormPrincipal.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado na ListView
                ListViewItem selectedItem = ltvFormPrincipal.SelectedItems[0];

                // Obtém os valores das colunas do item selecionado
                string codigo = selectedItem.SubItems[0].Text;
                string descricao = selectedItem.SubItems[1].Text;
                string codigoBarra = selectedItem.SubItems[2].Text;
                string unidade = selectedItem.SubItems[3].Text;
                string quantidade = selectedItem.SubItems[4].Text;
                string dataVencimento = selectedItem.SubItems[5].Text;
                string observacao = selectedItem.SubItems[7].Text;

                // Cria uma instância do FormCadastro e passa os valores para o construtor
                FormCadastro formEditar = new FormCadastro(this, codigo, descricao, codigoBarra, unidade, quantidade, dataVencimento, observacao);

                // Mostra o FormCadastro para edição
                formEditar.ShowDialog();

                // Desabilita o botão
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (ltvFormPrincipal.SelectedItems.Count > 0)
            {
                // Obtém o item selecionado na ListView
                ListViewItem selectedItem = ltvFormPrincipal.SelectedItems[0];

                // Obtém o código do item selecionado
                string codigo = selectedItem.SubItems[0].Text;

                // Mostra a mensagem de confirmação
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmação de exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Exclui o item do banco de dados
                    using (Connection connection = new Connection())
                    {
                        using (SqlConnection con = connection.OpenConnection())
                        {
                            try
                            {
                                string sql = "DELETE FROM tbl_ControleVenc WHERE Codigo = @Codigo";

                                using (SqlCommand command = new SqlCommand(sql, con))
                                {
                                    command.Parameters.AddWithValue("@Codigo", codigo);
                                    int rowsAffected = command.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        // Atualiza a ListView
                                        AtualizarListView();

                                        // Desabilita os botões
                                        btnExcluir.Enabled = false;
                                        btnEditar.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nenhum item foi excluído. Verifique os valores e tente novamente.");
                                    }
                                }
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show("Erro ao excluir item do banco de dados: " + err.Message);
                            }
                        }
                    }
                }
                else
                {
                    // Desabilita os botões
                    btnExcluir.Enabled = false;
                    btnEditar.Enabled = false;
                }
            }
        }
    }
}
