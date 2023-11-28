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
    }
}
