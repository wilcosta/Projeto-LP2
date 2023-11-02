using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent(); 
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();  // Esconde o formulário atual (frmMain).
            frmLogin fl = new frmLogin();  // Cria uma instância do formulário de login (frmLogin).
            fl.Show();  // Exibe o formulário de login.
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formCad = new FormCadastro();  // Cria uma instância do formulário de cadastro (FormCadastro).

            formCad.ShowDialog();  // Bloqueia a interação com demais formulários até que este formulário seja fechado.
        }
    }
}