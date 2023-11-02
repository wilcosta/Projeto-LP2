using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormCadastro : Form
    {
        private readonly Connection connection = new Connection();
        private readonly FormPrincipal formPrincipal;
        private readonly string codigo; // Variável para armazenar o código quando em modo de edição

        public FormCadastro(FormPrincipal principalForm)
        {
            InitializeComponent();
            this.formPrincipal = principalForm;
        }

        public FormCadastro(FormPrincipal principalForm, string codigo, string descricao, string codigoBarra, string unidade, string quantidade, string dataVencimento, string observacao)
        {
            InitializeComponent();
            this.formPrincipal = principalForm;

            if (!string.IsNullOrEmpty(codigo))
            {
                this.codigo = codigo; // Armazena o código para uso no modo de edição
                txbDescricao.Text = descricao;
                txbCodigoBarra.Text = codigoBarra;
                cmbUnidade.Text = unidade;
                txbQuantidade.Text = quantidade;
                mtbDataVencimento.Text = dataVencimento;
                txbObservacao.Text = observacao;

                BtnIncluir.Text = "Salvar";
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            string buttonText = BtnIncluir.Text;

            if (buttonText == "Incluir")
            {
                // Modo de inclusão
                string descricao = txbDescricao.Text;
                string codigoBarra = txbCodigoBarra.Text;
                string unidade = cmbUnidade.Text;
                string quantidade = txbQuantidade.Text;
                string dataVencimento = mtbDataVencimento.Text;
                string observacao = txbObservacao.Text;

                if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(codigoBarra) || string.IsNullOrEmpty(unidade) || string.IsNullOrEmpty(quantidade) || string.IsNullOrEmpty(dataVencimento))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                try
                {
                    DateTime dataVencimentoDate = DateTime.Parse(dataVencimento);
                    TimeSpan diasRestantes = dataVencimentoDate - DateTime.Now;
                    int diasRestantesValor = (int)diasRestantes.TotalDays;

                    string sql = "INSERT INTO tbl_ControleVenc (Descricao, CodigoBarra, Unidade, Quantidade, DataVencimento, Observacao, DiasRestantes) " +
                        "VALUES (@Descricao, @CodigoBarra, @Unidade, @Quantidade, @DataVencimento, @Observacao, @DiasRestantes)";

                    using (SqlConnection con = connection.ReturnConnection())
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", descricao);
                        cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
                        cmd.Parameters.AddWithValue("@Unidade", unidade);
                        cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@DataVencimento", dataVencimento);
                        cmd.Parameters.AddWithValue("@Observacao", observacao);
                        cmd.Parameters.AddWithValue("@DiasRestantes", diasRestantesValor);
                        cmd.Parameters.AddWithValue("@Codigo", DBNull.Value); // Defina @Codigo como NULL

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados inseridos com sucesso!");
                            LimparCampos();
                            formPrincipal.AtualizarListView();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado foi inserido. Verifique os valores e tente novamente.");
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("A data de vencimento não está em um formato válido.");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao inserir dados: " + err.Message);
                }
            }
            else if (buttonText == "Salvar")
            {
                // Modo de edição
                string descricao = txbDescricao.Text;
                string codigoBarra = txbCodigoBarra.Text;
                string unidade = cmbUnidade.Text;
                string quantidade = txbQuantidade.Text;
                string dataVencimento = mtbDataVencimento.Text;
                string observacao = txbObservacao.Text;

                if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(codigoBarra) || string.IsNullOrEmpty(unidade) || string.IsNullOrEmpty(quantidade) || string.IsNullOrEmpty(dataVencimento))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                    return;
                }

                try
                {
                    DateTime dataVencimentoDate = DateTime.Parse(dataVencimento);
                    TimeSpan diasRestantes = dataVencimentoDate - DateTime.Now;
                    int diasRestantesValor = (int)diasRestantes.TotalDays;

                    string sql = "UPDATE tbl_ControleVenc SET Descricao = @Descricao, CodigoBarra = @CodigoBarra, Unidade = @Unidade, Quantidade = @Quantidade, DataVencimento = @DataVencimento, Observacao = @Observacao, DiasRestantes = @DiasRestantes WHERE Codigo = @Codigo";

                    using (SqlConnection con = connection.ReturnConnection())
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", descricao);
                        cmd.Parameters.AddWithValue("@CodigoBarra", codigoBarra);
                        cmd.Parameters.AddWithValue("@Unidade", unidade);
                        cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                        cmd.Parameters.AddWithValue("@DataVencimento", dataVencimento);
                        cmd.Parameters.AddWithValue("@Observacao", observacao);
                        cmd.Parameters.AddWithValue("@DiasRestantes", diasRestantesValor);
                        cmd.Parameters.AddWithValue("@Codigo", codigo); // Use o código armazenado em modo de edição

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");
                            formPrincipal.AtualizarListView();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum dado foi atualizado. Verifique os valores e tente novamente.");
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("A data de vencimento não está em um formato válido.");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao atualizar dados: " + err.Message);
                }
            }
        }

        private void LimparCampos()
        {
            txbDescricao.Clear();
            txbCodigoBarra.Clear();
            cmbUnidade.SelectedIndex = -1;
            txbQuantidade.Clear();
            mtbDataVencimento.Clear();
            txbObservacao.Clear();
        }
    }
}
