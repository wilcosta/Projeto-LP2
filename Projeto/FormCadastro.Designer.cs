namespace Projeto
{
    partial class FormCadastro
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCodBar = new System.Windows.Forms.Label();
            this.lblUnid = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txbDescricao = new System.Windows.Forms.TextBox();
            this.txbCodigoBarra = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.txbObservacao = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblDataVenc = new System.Windows.Forms.Label();
            this.mtbDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(57, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCodBar
            // 
            this.lblCodBar.AutoSize = true;
            this.lblCodBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBar.Location = new System.Drawing.Point(57, 93);
            this.lblCodBar.Name = "lblCodBar";
            this.lblCodBar.Size = new System.Drawing.Size(136, 20);
            this.lblCodBar.TabIndex = 1;
            this.lblCodBar.Text = "Código de Barras:";
            // 
            // lblUnid
            // 
            this.lblUnid.AutoSize = true;
            this.lblUnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnid.Location = new System.Drawing.Point(57, 139);
            this.lblUnid.Name = "lblUnid";
            this.lblUnid.Size = new System.Drawing.Size(73, 20);
            this.lblUnid.TabIndex = 2;
            this.lblUnid.Text = "Unidade:";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(279, 139);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(96, 20);
            this.lblQtde.TabIndex = 3;
            this.lblQtde.Text = "Quantidade:";
            // 
            // txbDescricao
            // 
            this.txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescricao.Location = new System.Drawing.Point(147, 43);
            this.txbDescricao.MaxLength = 350;
            this.txbDescricao.Name = "txbDescricao";
            this.txbDescricao.Size = new System.Drawing.Size(337, 26);
            this.txbDescricao.TabIndex = 0;
            // 
            // txbCodigoBarra
            // 
            this.txbCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoBarra.Location = new System.Drawing.Point(199, 90);
            this.txbCodigoBarra.MaxLength = 13;
            this.txbCodigoBarra.Name = "txbCodigoBarra";
            this.txbCodigoBarra.Size = new System.Drawing.Size(285, 26);
            this.txbCodigoBarra.TabIndex = 1;
            this.txbCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCodigoBarra_KeyPress);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantidade.Location = new System.Drawing.Point(381, 136);
            this.txbQuantidade.MaxLength = 10;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(103, 26);
            this.txbQuantidade.TabIndex = 3;
            this.txbQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbQuantidade_KeyPress);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIncluir.Location = new System.Drawing.Point(199, 279);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(150, 35);
            this.BtnIncluir.TabIndex = 6;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "BOBINA",
            "CAIXA",
            "EMBALAGEM",
            "FARDO",
            "FOLHA",
            "FRASCO",
            "GALÃO",
            "JOGO",
            "KIT",
            "LITRO",
            "PACOTE",
            "PEÇA",
            "RESMA",
            "ROLO",
            "SACO",
            "TUBO",
            "UNIDADE",
            "VIDRO"});
            this.cmbUnidade.Location = new System.Drawing.Point(136, 136);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(137, 28);
            this.cmbUnidade.TabIndex = 2;
            // 
            // txbObservacao
            // 
            this.txbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbObservacao.Location = new System.Drawing.Point(109, 228);
            this.txbObservacao.MaxLength = 250;
            this.txbObservacao.Name = "txbObservacao";
            this.txbObservacao.Size = new System.Drawing.Size(375, 26);
            this.txbObservacao.TabIndex = 5;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(57, 231);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(46, 20);
            this.lblObs.TabIndex = 10;
            this.lblObs.Text = "Obs.:";
            // 
            // lblDataVenc
            // 
            this.lblDataVenc.AutoSize = true;
            this.lblDataVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVenc.Location = new System.Drawing.Point(57, 185);
            this.lblDataVenc.Name = "lblDataVenc";
            this.lblDataVenc.Size = new System.Drawing.Size(159, 20);
            this.lblDataVenc.TabIndex = 12;
            this.lblDataVenc.Text = "Data de Vencimento:";
            // 
            // mtbDataVencimento
            // 
            this.mtbDataVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDataVencimento.Location = new System.Drawing.Point(222, 182);
            this.mtbDataVencimento.Mask = "00/00/0000";
            this.mtbDataVencimento.Name = "mtbDataVencimento";
            this.mtbDataVencimento.Size = new System.Drawing.Size(94, 26);
            this.mtbDataVencimento.TabIndex = 4;
            this.mtbDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 376);
            this.Controls.Add(this.mtbDataVencimento);
            this.Controls.Add(this.lblDataVenc);
            this.Controls.Add(this.txbObservacao);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.cmbUnidade);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbCodigoBarra);
            this.Controls.Add(this.txbDescricao);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblUnid);
            this.Controls.Add(this.lblCodBar);
            this.Controls.Add(this.lblDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCodBar;
        private System.Windows.Forms.Label lblUnid;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.TextBox txbCodigoBarra;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.TextBox txbObservacao;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblDataVenc;
        private System.Windows.Forms.MaskedTextBox mtbDataVencimento;
    }
}