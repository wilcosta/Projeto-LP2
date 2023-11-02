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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Por favor insira seu usuário e senha");
                return;
            }
            try
            { 
                // Conexão SQL
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from tbl_Login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txt_UserName.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                // Verificação para mostrar o formulário frmMain
                if (count == 1)
                {
                    MessageBox.Show("Login efetuado com sucesso!");
                    this.Hide();
                    frmMain fm = new frmMain();
                    fm.Show();
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