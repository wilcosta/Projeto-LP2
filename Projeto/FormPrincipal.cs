﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.IO;
using System.Text;

namespace Projeto
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal(string nomeDoUsuario)
        {
            // Inicializa os controles do formulário, carrega os dados na ListView, desabilita os botões "Editar" e "Excluir",
            // define o texto do rótulo "lblSaudacao" e associa o evento KeyUp do TextBox "txbBuscar" ao método BtnBuscar_KeyUp.

            InitializeComponent();
            AtualizarListView();
            btnEditar.Enabled = false;
            btnApagar.Enabled = false;
            lblSaudacao.Text = "Olá, " + nomeDoUsuario + " seja bem-vindo(a)!";
            txbBuscar.KeyUp += new KeyEventHandler(BtnBuscar_KeyUp);
        }

        // Realiza o cálculo dos dias restantes com base na data atual do sistema.

        private int CalcularDiasRestantes(DateTime dataVencimento)
        {
            TimeSpan diff = dataVencimento.Date - DateTime.Now.Date;
            return diff.Days;
        }


        // Recupera os dados de uma tabela do banco de dados e os exibe na ListView. Primeiro, ele limpa a ListView. Em seguida, ele conecta-se ao banco
        // de dados e executa uma consulta SQL para obter os dados. Depois, ele percorre os resultados da consulta e cria um item da ListView para cada linha.
        // Por fim, ele adiciona os itens da consulta à ListView. Também é tratado eventuais erros que possam ocorrer durante este processo.

        public void AtualizarListView()
        {
            ltvFormPrincipal.Items.Clear();
            using (Connection connection = new Connection())
            {
                using (SqlConnection con = connection.OpenConnection())
                {
                    try
                    {
                        string sql = "SELECT Codigo, Descricao, CodigoBarra, Unidade, Quantidade, DataVencimento, Observacao FROM tbl_ControleVenc";

                        using (SqlCommand command = new SqlCommand(sql, con))
                        {
                            SqlDataReader reader = command.ExecuteReader();

                            // Criar uma lista para armazenar os itens da ListView
                            List<ListViewItem> itens = new List<ListViewItem>();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["Codigo"].ToString());
                                item.SubItems.Add(reader["Descricao"].ToString());
                                item.SubItems.Add(reader["CodigoBarra"].ToString());
                                item.SubItems.Add(reader["Unidade"].ToString());
                                item.SubItems.Add(reader["Quantidade"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["DataVencimento"]).ToShortDateString());
                                int diasRestantes = CalcularDiasRestantes(Convert.ToDateTime(reader["DataVencimento"]));

                                if (diasRestantes < 0)
                                {
                                    item.SubItems.Add("Vencido");
                                }
                                else if (diasRestantes == 0)
                                {
                                    item.SubItems.Add("Vence Hoje");
                                }
                                else
                                {
                                    item.SubItems.Add(diasRestantes.ToString());
                                }

                                item.SubItems.Add(reader["Observacao"].ToString());
                                itens.Add(item);
                            }

                            reader.Close();

                            // Realiza a ordenação dos itens com base no campo "DiasRestantes"
                            itens.Sort((item1, item2) =>
                            {
                                string status1 = item1.SubItems[6].Text;
                                string status2 = item2.SubItems[6].Text;

                                // Realiza a ordenação personalizada:
                                if (status1 == "Vencido") return -1; // "Vencido(s)" fica primeiro
                                if (status2 == "Vencido") return 1;
                                if (status1 == "Vence Hoje") return -1; // "Vence(m) Hoje" fica em seguida
                                if (status2 == "Vence Hoje") return 1;

                                // Realiza a ordenação por dias restantes em ordem crescente
                                int diasRestantesItem1 = int.Parse(item1.SubItems[6].Text);
                                int diasRestantesItem2 = int.Parse(item2.SubItems[6].Text);
                                return diasRestantesItem1.CompareTo(diasRestantesItem2);
                            });

                            // Adiciona os itens ordenados à ListView
                            ltvFormPrincipal.Items.AddRange(itens.ToArray());
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erro ao carregar registros do banco de dados: " + err.Message);
                    }
                }
            }
        }


        // Se o usuário clicar no link "logoff", esse método fecha a tela principal e abre novamentente a tela de "Login",
        // permitindo assim a troca de usuário, por exemplo.

        private void LnkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        // Se o usuário clicar no botão "Cadastrar", será aberta uma nova tela que possibilitará o cadastro de produto(s).
        // Na nova janela que se abre, o usuário precisa preencher os dados mínimos para efetivar o cadastro.

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrarProdutos formCad = new FormCadastrarProdutos(this);
            formCad.ShowDialog();
        }

        // Este código será executado toda vez que o usuário clicar duas vezes em um item da ListView. O código verifica se o item está selecionado.
        // Se o item estiver selecionado, o código ativa os botões "Editar" e "Excluir", permitindo tais funcionalidades.

        private void LtvFormPrincipal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ltvFormPrincipal.SelectedItems.Count > 0)
            {
                btnEditar.Enabled = true;
                btnApagar.Enabled = true;
            }
        }

        // Se o usuário clicar no botão "Editar", o código verifica se foi selecionado um item da ListView. Se sim, será aberta uma nova tela
        // que possibilitará a edição deste item, ou seja, a nova janela conterá os dados do item selecionado e o usuário poderá realizar alterações.
        // Ao final deverá clicar no botão "Salvar", para gravar as modificações realizadas, e os botões "Editar" e "Excluir", voltarão a ficar inativos.

        private void BtnDetalhar_Click(object sender, EventArgs e)
        {
            if (ltvFormPrincipal.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ltvFormPrincipal.SelectedItems[0];

                string codigo = selectedItem.SubItems[0].Text;
                string descricao = selectedItem.SubItems[1].Text;
                string codigoBarra = selectedItem.SubItems[2].Text;
                string unidade = selectedItem.SubItems[3].Text;
                string quantidade = selectedItem.SubItems[4].Text;
                string dataVencimento = selectedItem.SubItems[5].Text;
                string observacao = selectedItem.SubItems[7].Text;

                FormCadastrarProdutos formEditar = new FormCadastrarProdutos(this, codigo, descricao, codigoBarra, unidade, quantidade, dataVencimento, observacao);
                
                formEditar.ShowDialog();
                
                btnEditar.Enabled = false;
                btnApagar.Enabled = false;
            }
        }

        // Se o usuário clicar no botão "Excluir", o código verifica se um item está selecionado na ListView. Se sim, o código mostra uma caixa de diálogo
        // para confirmar a exclusão. Se o usuário confirmar, será estabelecida uma conexão com o banco de dados e será criado o comando SQL para excluir o item
        // do banco de dados. Executado o comando e verificado se a exclusão foi bem-sucedida, os botões "Excluir" e "Editar" voltarão a ficar inativos. Se houver
        // falhar no comando SQL, será exibida uma mensagem de erro ao usuário. Caso o usuário cancele a exclusão, os botões "Excluir" e "Editar" serão desabilitados.

        private void BtnExcluir_Click(object sender, EventArgs e)
            {
            if (ltvFormPrincipal.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ltvFormPrincipal.SelectedItems[0];
                                
                string codigo = selectedItem.SubItems[0].Text;
                                
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o item selecionado?", "Confirmação de exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
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
                                        AtualizarListView();

                                        btnApagar.Enabled = false;
                                        btnEditar.Enabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nenhum item foi excluído. Verifique os valores e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    btnApagar.Enabled = false;
                    btnEditar.Enabled = false;
                }
            }
        }

        // Utilizado para cancelar a seleção de um item, com clique simples ou clique duplo, desde que seja clicado em algum lugar neutro do
        // Form ou da ListView, ou seja, tem a função de anular a seleção de um item e ao mesmo tempo desativar os botões "Excluir" e "Editar".
        // Os botões só devem estar habilitados se um item da ListView for selecionado com duplo clique do mouse.

        private void LtvFormPrincipal_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ListViewItem item = ltvFormPrincipal.GetItemAt(e.X, e.Y);

                if (item == null)
                {
                    btnApagar.Enabled = false;
                    btnEditar.Enabled = false;
                }
            }
        }

        // Se o usuário clicar no botão "Buscar", o código verifica se o usuário digitou algo na caixa de texto. Se sim, o código procura o termo de busca
        // nos itens da ListView. Se o termo de busca for encontrado em algum item, o item é selecionado. Os botões "Editar" e "Excluir" são desativados
        // para evitar que o usuário edite ou exclua um item que não foi selecionado.

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string termoDeBusca = txbBuscar.Text.ToLower(); 

            if (string.IsNullOrEmpty(termoDeBusca))
            {
                AtualizarListView();
            }
            else
            {
                foreach (ListViewItem item in ltvFormPrincipal.Items)
                {
                    bool encontrado = false;
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(termoDeBusca))
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    item.Selected = encontrado;
                }
            }

            btnEditar.Enabled = false;
            btnApagar.Enabled = false;

            txbBuscar.Text = "";
        }

        // Permite que o usuário pesquise por itens na ListView de forma mais rápida e fácil, sem precisar clicar no botão "Buscar".
        // Neste caso, será verificado se a tecla Enter foi pressionada, se sim, o método responsável pela procura do item na ListView
        // realizará a pesquisa de acordo com o texto que o usuário digitou na caixa de texto txbBuscar.

        private void BtnBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnBuscar_Click(sender, e);
            }
        }

        private void BtnRegistrarBaixa_Click(object sender, EventArgs e)
        {
            FormRegistrarBaixa formBaixa = new FormRegistrarBaixa();
            formBaixa.ShowDialog();
        }

        private void BtnGerenciar_Click(object sender, EventArgs e)
        {
            FormGerenciar formGestao = new FormGerenciar();
            formGestao.ShowDialog();
        }

        // Método de Geração de Relatório CSV
        private void GerarRelatorioCSV()
        {
            // Obtém o caminho para gravar no Desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Realiza a combinação do caminho do Desktop com o nome do arquivo CSV
            string filePath = Path.Combine(desktopPath, "relatorio.csv");

            // Cria o arquivo CSV com a codificação UTF-8 para evitar problemas de acentuação
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // "Escreve" / replica o mesmo cabeçalho da ListView
                writer.WriteLine("Código;Descrição;Código de Barras;Unidade;Quantidade;Data Vencimento;Dias Restantes;Observação");

                // Escreve os dados
                foreach (ListViewItem item in ltvFormPrincipal.Items)
                {
                    // Obtém os textos de cada subitem, separados por ponto e vírgula
                    string codigoBarras = $"\'{item.SubItems[2].Text}"; // Adiciona uma aspa simples antes do código de barras p/ evitar formato científico no Excel
                    string line = $"{item.SubItems[0].Text};{item.SubItems[1].Text};{codigoBarras};{item.SubItems[3].Text};{item.SubItems[4].Text};{item.SubItems[5].Text};{item.SubItems[6].Text};{item.SubItems[7].Text}";

                    writer.WriteLine(line);
                }
            } 

            MessageBox.Show($"Relatório gerado com sucesso em: {filePath}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGerarRelatorioCSV_Click(object sender, EventArgs e)
        {
            GerarRelatorioCSV();
        }
    }
}