namespace Projeto
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.ltvFormPrincipal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.tblLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrarBaixa = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerarRelatorioCSV = new System.Windows.Forms.Button();
            this.tblLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(13, 616);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(150, 35);
            this.btnApagar.TabIndex = 11;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(171, 616);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 35);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnDetalhar_Click);
            // 
            // ltvFormPrincipal
            // 
            this.ltvFormPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvFormPrincipal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ltvFormPrincipal.FullRowSelect = true;
            this.ltvFormPrincipal.GridLines = true;
            this.ltvFormPrincipal.HideSelection = false;
            this.ltvFormPrincipal.Location = new System.Drawing.Point(13, 98);
            this.ltvFormPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvFormPrincipal.Name = "ltvFormPrincipal";
            this.ltvFormPrincipal.Size = new System.Drawing.Size(1324, 510);
            this.ltvFormPrincipal.TabIndex = 12;
            this.ltvFormPrincipal.UseCompatibleStateImageBehavior = false;
            this.ltvFormPrincipal.View = System.Windows.Forms.View.Details;
            this.ltvFormPrincipal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LtvFormPrincipal_MouseDoubleClick);
            this.ltvFormPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LtvFormPrincipal_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código de Barras";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unid. Medida";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vencimento";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dias Restantes";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Observação";
            this.columnHeader8.Width = 260;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1187, 53);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 35);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.btnBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnBuscar_KeyUp);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(874, 616);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(150, 35);
            this.BtnCadastrar.TabIndex = 22;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // txbBuscar
            // 
            this.txbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBuscar.Location = new System.Drawing.Point(874, 58);
            this.txbBuscar.MaxLength = 50;
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(307, 29);
            this.txbBuscar.TabIndex = 23;
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaudacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(143)))), ((int)(((byte)(154)))));
            this.lblSaudacao.Location = new System.Drawing.Point(166, 0);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(82, 20);
            this.lblSaudacao.TabIndex = 24;
            this.lblSaudacao.Text = "Saudacao";
            this.lblSaudacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnkLabel
            // 
            this.lnkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(219)))));
            this.lnkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLabel.AutoSize = true;
            this.lnkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(219)))));
            this.lnkLabel.Location = new System.Drawing.Point(254, 0);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(51, 18);
            this.lnkLabel.TabIndex = 25;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "logoff";
            this.lnkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(219)))));
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLabel_LinkClicked);
            // 
            // tblLayoutPanel
            // 
            this.tblLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayoutPanel.ColumnCount = 2;
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.49351F));
            this.tblLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.50649F));
            this.tblLayoutPanel.Controls.Add(this.lnkLabel, 1, 0);
            this.tblLayoutPanel.Controls.Add(this.lblSaudacao, 0, 0);
            this.tblLayoutPanel.Location = new System.Drawing.Point(1029, 12);
            this.tblLayoutPanel.Name = "tblLayoutPanel";
            this.tblLayoutPanel.RowCount = 1;
            this.tblLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayoutPanel.Size = new System.Drawing.Size(308, 21);
            this.tblLayoutPanel.TabIndex = 26;
            // 
            // btnRegistrarBaixa
            // 
            this.btnRegistrarBaixa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarBaixa.Location = new System.Drawing.Point(1031, 616);
            this.btnRegistrarBaixa.Name = "btnRegistrarBaixa";
            this.btnRegistrarBaixa.Size = new System.Drawing.Size(150, 35);
            this.btnRegistrarBaixa.TabIndex = 27;
            this.btnRegistrarBaixa.Text = "Registrar Baixa";
            this.btnRegistrarBaixa.UseVisualStyleBackColor = true;
            this.btnRegistrarBaixa.Click += new System.EventHandler(this.BtnRegistrarBaixa_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerenciar.Location = new System.Drawing.Point(1187, 616);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(150, 35);
            this.btnGerenciar.TabIndex = 28;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.BtnGerenciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerarRelatorioCSV
            // 
            this.btnGerarRelatorioCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerarRelatorioCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorioCSV.Location = new System.Drawing.Point(329, 616);
            this.btnGerarRelatorioCSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerarRelatorioCSV.Name = "btnGerarRelatorioCSV";
            this.btnGerarRelatorioCSV.Size = new System.Drawing.Size(150, 35);
            this.btnGerarRelatorioCSV.TabIndex = 30;
            this.btnGerarRelatorioCSV.Text = "Relatório";
            this.btnGerarRelatorioCSV.UseVisualStyleBackColor = true;
            this.btnGerarRelatorioCSV.Click += new System.EventHandler(this.BtnGerarRelatorioCSV_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 689);
            this.Controls.Add(this.btnGerarRelatorioCSV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnRegistrarBaixa);
            this.Controls.Add(this.tblLayoutPanel);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ltvFormPrincipal);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel Principal - Controle de Validades";
            this.tblLayoutPanel.ResumeLayout(false);
            this.tblLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListView ltvFormPrincipal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.LinkLabel lnkLabel;
        private System.Windows.Forms.TableLayoutPanel tblLayoutPanel;
        private System.Windows.Forms.Button btnRegistrarBaixa;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGerarRelatorioCSV;
    }
}