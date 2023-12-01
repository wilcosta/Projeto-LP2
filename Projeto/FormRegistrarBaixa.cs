using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormRegistrarBaixa : Form
    {
        private readonly Connection connection;

        public FormRegistrarBaixa()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void CarregarDados()
        {
            using (SqlConnection con = connection.OpenConnection())
            {
                string query = "SELECT Codigo, Descricao, DataVencimento, Quantidade FROM tbl_ControleVenc WHERE Quantidade >= 1";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        ltvRegBaixaSelecionar.Clear();

                        ltvRegBaixaSelecionar.Columns.Add("", 25);
                        ltvRegBaixaSelecionar.Columns.Add("Código", 65);
                        ltvRegBaixaSelecionar.Columns.Add("Descrição", 420);
                        ltvRegBaixaSelecionar.Columns.Add("Vencimento", 110);
                        ltvRegBaixaSelecionar.Columns.Add("Quantidade", 105);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            ListViewItem item = new ListViewItem("");
                            item.SubItems.Add(row["Codigo"].ToString());
                            item.SubItems.Add(row["Descricao"].ToString());
                            item.SubItems.Add(((DateTime)row["DataVencimento"]).ToShortDateString());
                            item.SubItems.Add(row["Quantidade"].ToString());
                            ltvRegBaixaSelecionar.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void FormRegistrarBaixa_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = new List<int>();

            for (int i = 0; i < ltvRegBaixaSelecionar.Items.Count; i++)
            {
                if (ltvRegBaixaSelecionar.Items[i].Checked)
                {
                    selectedIndices.Add(i);
                }
            }

            if (selectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione um item para adicionar à lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = selectedIndices.Count - 1; i >= 0; i--)
            {
                ListViewItem selectedItem = ltvRegBaixaSelecionar.Items[selectedIndices[i]];

                bool itemExists = false;
                foreach (ListViewItem item in ltvRegBaixaSelecionado.Items)
                {
                    if (item.SubItems[1].Text == selectedItem.SubItems[1].Text)
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    ListViewItem newItem = new ListViewItem("");
                    newItem.SubItems.Add(selectedItem.SubItems[1].Text);
                    newItem.SubItems.Add(selectedItem.SubItems[2].Text);
                    newItem.SubItems.Add(selectedItem.SubItems[3].Text);

                    TextBox quantidadeTextBox = new TextBox
                    {
                        Width = ltvRegBaixaSelecionado.Columns[4].Width,
                        Tag = newItem
                    };
                    quantidadeTextBox.TextChanged += QuantidadeTextBox_TextChanged;

                    newItem.SubItems.Add(quantidadeTextBox.Text);
                    ltvRegBaixaSelecionado.Items.Add(newItem);
                    ltvRegBaixaSelecionado.Controls.Add(quantidadeTextBox);
                    quantidadeTextBox.Bounds = newItem.SubItems[4].Bounds;

                    selectedItem.Checked = false;
                }
                else
                {
                    MessageBox.Show("Este item já foi adicionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void QuantidadeTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            ListViewItem item = (ListViewItem)textBox.Tag;
            item.SubItems[4].Text = textBox.Text;
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = new List<int>();

            for (int i = ltvRegBaixaSelecionado.Items.Count - 1; i >= 0; i--)
            {
                if (ltvRegBaixaSelecionado.Items[i].Checked)
                {
                    selectedIndices.Add(i);
                }
            }

            if (selectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione um item para remover da lista.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (int selectedIndex in selectedIndices)
            {
                ltvRegBaixaSelecionado.Items.RemoveAt(selectedIndex);
            }

            List<Control> controlsToRemove = new List<Control>();
            foreach (Control control in ltvRegBaixaSelecionado.Controls)
            {
                if (control is TextBox textBox)
                {
                    bool associatedItem = false;
                    foreach (ListViewItem item in ltvRegBaixaSelecionado.Items)
                    {
                        if (item.Tag == textBox)
                        {
                            associatedItem = true;
                            break;
                        }
                    }

                    if (!associatedItem)
                    {
                        controlsToRemove.Add(textBox);
                    }
                }
            }

            foreach (Control control in controlsToRemove)
            {
                ltvRegBaixaSelecionado.Controls.Remove(control);
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string termoDeBusca = txbPesquisa.Text.ToLower();

            if (string.IsNullOrEmpty(termoDeBusca))
            {
                CarregarDados();
            }
            else
            {
                foreach (ListViewItem item in ltvRegBaixaSelecionar.Items)
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

            txbPesquisa.Text = "";
        }

        private void BtnPesquisar_KeyUp(object sender, KeyEventArgs e)
        {




        }


        private void BntConfirmar_Click(object sender, EventArgs e)
        {




        }


    }
}
