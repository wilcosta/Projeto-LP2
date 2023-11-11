using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormCadastro : Form
    {
        // Variáveis usadas para acessar os dados do banco de dados e a tela principal.
		
		private readonly Connection connection = new Connection();
        private readonly FormPrincipal formPrincipal;
        private readonly string codigo; 

		// Inicializa os componentes da tela FormCadastro e armazena uma referência à tela principal na variável formPrincipal.

        public FormCadastro(FormPrincipal principalForm)
        {
            InitializeComponent();
            this.formPrincipal = principalForm;
        }

		// Inicializa os componentes da tela FormCadastro e após verificar se o "código" do produto não é vazio, as linhas de códigos seguintes 
		// preenchem os campos com as informações fornecidas nos parâmetros. A última linha altera o texto do botão "Incluir" para "Salvar".
		
        public FormCadastro(FormPrincipal principalForm, string codigo, string descricao, string codigoBarra, string unidade, string quantidade, string dataVencimento, string observacao)
        {
            InitializeComponent();
            this.formPrincipal = principalForm;

            if (!string.IsNullOrEmpty(codigo))
            {
                this.codigo = codigo; 
                txbDescricao.Text = descricao;
                txbCodigoBarra.Text = codigoBarra;
                cmbUnidade.Text = unidade;
                txbQuantidade.Text = quantidade;
                mtbDataVencimento.Text = dataVencimento;
                txbObservacao.Text = observacao;

                BtnIncluir.Text = "Salvar";
            }
        }

        // Tem a funcionalidade de gerenciar a inclusão e atualização de informações no banco de dados a partir dos valores fornecidos nos campos do formulário. 
        // Para tanto, verifica se os campos obrigatórios estão preenchidos, converte a data de vencimento, prepara instruções SQL seguras e lida com erros. 
        // Após a conclusão da operação, exibe mensagens de sucesso ou erro e atualiza a interface do usuário.

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            string buttonText = BtnIncluir.Text;

            if (!ValidarGtin13(txbCodigoBarra.Text.Trim()))
            {
                MessageBox.Show("Código de barras inválido, verifique...", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (buttonText == "Incluir")
            {
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
                    DateTime dataVencimentoDate = Convert.ToDateTime(dataVencimento);
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
                        cmd.Parameters.AddWithValue("@DataVencimento", dataVencimentoDate);
                        cmd.Parameters.AddWithValue("@Observacao", observacao);
                        cmd.Parameters.AddWithValue("@DiasRestantes", diasRestantesValor);
                        cmd.Parameters.AddWithValue("@Codigo", DBNull.Value);

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
                catch (FormatException err)
                {
                    MessageBox.Show("A data de vencimento não está em um formato válido. " + err.Message);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro ao inserir dados: " + err.Message);
                }
            }
            else if (buttonText == "Salvar")
            {
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
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

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

		// Tem a funcionalidade de apagar ou "limpar" os dados inseridos nos diferentes campos do formulário, 
		// deixando-os vazios ou com valores padrão, de forma a preparar o formulário para uma nova entrada de informações.

        private void LimparCampos()
        {
            txbDescricao.Clear();
            txbCodigoBarra.Clear();
            cmbUnidade.SelectedIndex = -1;
            txbQuantidade.Clear();
            mtbDataVencimento.Clear();
            txbObservacao.Clear();
        }

        // Algoritmo de verificação de Código de Barras GTIN-13
        
        private bool ValidarGtin13(string gtin13)
        {
            if (gtin13.Length == 13)
            {
                var cGtin13 = gtin13.Substring(0, 12);
                var dig = Convert.ToByte(gtin13.Substring(gtin13.Length - 1));
                byte x;
                short soma = 0;
                byte result;

                for (byte i = 0; i < 12; i++)
                {
                    if ((i + 1) % 2 != 0)
                        // posição ímpar
                        x = Convert.ToByte(cGtin13.Substring(i, 1));
                    else
                        // posição par
                        x = (byte)(Convert.ToByte(cGtin13.Substring(i, 1)) * 3);

                    soma += x;
                }

                x = (byte)((Convert.ToInt16(soma / 10) + 1) * 10);
                result = (byte)(x - soma == 10 ? 0 : x - soma);

                if (dig == result)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}