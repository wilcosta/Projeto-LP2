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

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            
            FormCadastro formCad = new FormCadastro();
            formCad.ShowDialog(); 
        }
    }
}