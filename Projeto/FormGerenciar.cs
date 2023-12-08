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
    public partial class FormGerenciar : Form
    {
        private readonly Connection connection;

        public FormGerenciar()
        {
            InitializeComponent();

            
            this.connection = new Connection(); 
        }

        private void BtnCadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            FormCadastrarUsuarios frmCadastro = new FormCadastrarUsuarios(connection);
            frmCadastro.ShowDialog();
        }
    }
}