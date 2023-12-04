namespace Projeto
{
    partial class FormGerenciar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarNovoUsuario = new System.Windows.Forms.Button();
            this.btnRedefinirSenhaUsuario = new System.Windows.Forms.Button();
            this.btnExibirUsuariosCadastrados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarNovoUsuario
            // 
            this.btnCadastrarNovoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarNovoUsuario.Location = new System.Drawing.Point(17, 46);
            this.btnCadastrarNovoUsuario.Name = "btnCadastrarNovoUsuario";
            this.btnCadastrarNovoUsuario.Size = new System.Drawing.Size(283, 65);
            this.btnCadastrarNovoUsuario.TabIndex = 0;
            this.btnCadastrarNovoUsuario.Text = "Cadastrar Novo Usuário";
            this.btnCadastrarNovoUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarNovoUsuario.Click += new System.EventHandler(this.BtnCadastrarNovoUsuario_Click);
            // 
            // btnRedefinirSenhaUsuario
            // 
            this.btnRedefinirSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedefinirSenhaUsuario.Location = new System.Drawing.Point(17, 117);
            this.btnRedefinirSenhaUsuario.Name = "btnRedefinirSenhaUsuario";
            this.btnRedefinirSenhaUsuario.Size = new System.Drawing.Size(283, 65);
            this.btnRedefinirSenhaUsuario.TabIndex = 1;
            this.btnRedefinirSenhaUsuario.Text = "Redefinir Senha";
            this.btnRedefinirSenhaUsuario.UseVisualStyleBackColor = true;
            // 
            // btnExibirUsuariosCadastrados
            // 
            this.btnExibirUsuariosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirUsuariosCadastrados.Location = new System.Drawing.Point(17, 188);
            this.btnExibirUsuariosCadastrados.Name = "btnExibirUsuariosCadastrados";
            this.btnExibirUsuariosCadastrados.Size = new System.Drawing.Size(283, 65);
            this.btnExibirUsuariosCadastrados.TabIndex = 2;
            this.btnExibirUsuariosCadastrados.Text = "Exibir Usuários Cadastrados";
            this.btnExibirUsuariosCadastrados.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExibirUsuariosCadastrados);
            this.groupBox1.Controls.Add(this.btnRedefinirSenhaUsuario);
            this.groupBox1.Controls.Add(this.btnCadastrarNovoUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão de Usuários";
            // 
            // FormGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 297);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarNovoUsuario;
        private System.Windows.Forms.Button btnRedefinirSenhaUsuario;
        private System.Windows.Forms.Button btnExibirUsuariosCadastrados;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}