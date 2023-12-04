namespace Projeto
{
    partial class FormCadastrarUsuarios
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
            this.BtnCadastrarUsuario = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastrarUsuario
            // 
            this.BtnCadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrarUsuario.Location = new System.Drawing.Point(116, 156);
            this.BtnCadastrarUsuario.Name = "BtnCadastrarUsuario";
            this.BtnCadastrarUsuario.Size = new System.Drawing.Size(111, 37);
            this.BtnCadastrarUsuario.TabIndex = 9;
            this.BtnCadastrarUsuario.Text = "Cadastrar";
            this.BtnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.BtnCadastrarUsuario.Click += new System.EventHandler(this.BtnCadastrarUsuario_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(83, 94);
            this.txbSenha.MaxLength = 30;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(235, 26);
            this.txbSenha.TabIndex = 8;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.Location = new System.Drawing.Point(83, 45);
            this.txbNome.MaxLength = 30;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(235, 26);
            this.txbNome.TabIndex = 7;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(22, 97);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 6;
            this.lblSenha.Text = "Senha:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(27, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // FormCadastrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 236);
            this.Controls.Add(this.BtnCadastrarUsuario);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrarUsuario;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
    }
}