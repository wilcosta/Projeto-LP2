namespace Projeto
{
    partial class FormRegistrarBaixa
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.ltvRegBaixaSelecionar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.ltvRegBaixaSelecionado = new System.Windows.Forms.ListView();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.bntConfirmar = new System.Windows.Forms.Button();
            this.gpbSelecionar = new System.Windows.Forms.GroupBox();
            this.gpbSelecionado = new System.Windows.Forms.GroupBox();
            this.gpbSelecionar.SuspendLayout();
            this.gpbSelecionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(14, 267);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(150, 35);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // ltvRegBaixaSelecionar
            // 
            this.ltvRegBaixaSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvRegBaixaSelecionar.CheckBoxes = true;
            this.ltvRegBaixaSelecionar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ltvRegBaixaSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvRegBaixaSelecionar.GridLines = true;
            this.ltvRegBaixaSelecionar.HideSelection = false;
            this.ltvRegBaixaSelecionar.Location = new System.Drawing.Point(16, 70);
            this.ltvRegBaixaSelecionar.Name = "ltvRegBaixaSelecionar";
            this.ltvRegBaixaSelecionar.Size = new System.Drawing.Size(752, 221);
            this.ltvRegBaixaSelecionar.TabIndex = 3;
            this.ltvRegBaixaSelecionar.UseCompatibleStateImageBehavior = false;
            this.ltvRegBaixaSelecionar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Descrição";
            this.columnHeader3.Width = 420;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vencimento";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Requerida";
            this.columnHeader10.Width = 105;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Vencimento";
            this.columnHeader9.Width = 110;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Descrição";
            this.columnHeader8.Width = 420;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Código";
            this.columnHeader7.Width = 65;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 25;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(618, 25);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(150, 35);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(16, 301);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(150, 35);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // ltvRegBaixaSelecionado
            // 
            this.ltvRegBaixaSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvRegBaixaSelecionado.CheckBoxes = true;
            this.ltvRegBaixaSelecionado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.ltvRegBaixaSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvRegBaixaSelecionado.FullRowSelect = true;
            this.ltvRegBaixaSelecionado.GridLines = true;
            this.ltvRegBaixaSelecionado.HideSelection = false;
            this.ltvRegBaixaSelecionado.Location = new System.Drawing.Point(14, 34);
            this.ltvRegBaixaSelecionado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltvRegBaixaSelecionado.Name = "ltvRegBaixaSelecionado";
            this.ltvRegBaixaSelecionado.Size = new System.Drawing.Size(752, 221);
            this.ltvRegBaixaSelecionado.TabIndex = 5;
            this.ltvRegBaixaSelecionado.UseCompatibleStateImageBehavior = false;
            this.ltvRegBaixaSelecionado.View = System.Windows.Forms.View.Details;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(302, 32);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(309, 26);
            this.txbPesquisa.TabIndex = 1;
            // 
            // bntConfirmar
            // 
            this.bntConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntConfirmar.Location = new System.Drawing.Point(616, 267);
            this.bntConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntConfirmar.Name = "bntConfirmar";
            this.bntConfirmar.Size = new System.Drawing.Size(150, 35);
            this.bntConfirmar.TabIndex = 7;
            this.bntConfirmar.Text = "Confirmar";
            this.bntConfirmar.UseVisualStyleBackColor = true;
            // 
            // gpbSelecionar
            // 
            this.gpbSelecionar.BackColor = System.Drawing.SystemColors.Control;
            this.gpbSelecionar.Controls.Add(this.ltvRegBaixaSelecionar);
            this.gpbSelecionar.Controls.Add(this.btnPesquisar);
            this.gpbSelecionar.Controls.Add(this.btnAdicionar);
            this.gpbSelecionar.Controls.Add(this.txbPesquisa);
            this.gpbSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSelecionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbSelecionar.Location = new System.Drawing.Point(12, 15);
            this.gpbSelecionar.Name = "gpbSelecionar";
            this.gpbSelecionar.Size = new System.Drawing.Size(785, 354);
            this.gpbSelecionar.TabIndex = 42;
            this.gpbSelecionar.TabStop = false;
            this.gpbSelecionar.Text = "À selecionar";
            // 
            // gpbSelecionado
            // 
            this.gpbSelecionado.Controls.Add(this.ltvRegBaixaSelecionado);
            this.gpbSelecionado.Controls.Add(this.bntConfirmar);
            this.gpbSelecionado.Controls.Add(this.btnRemover);
            this.gpbSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSelecionado.Location = new System.Drawing.Point(14, 388);
            this.gpbSelecionado.Name = "gpbSelecionado";
            this.gpbSelecionado.Size = new System.Drawing.Size(783, 318);
            this.gpbSelecionado.TabIndex = 43;
            this.gpbSelecionado.TabStop = false;
            this.gpbSelecionado.Text = "Selecionado(s)";
            // 
            // FormRegistrarBaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 721);
            this.Controls.Add(this.gpbSelecionar);
            this.Controls.Add(this.gpbSelecionado);
            this.Name = "FormRegistrarBaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Baixa";
            this.Load += new System.EventHandler(this.FormRegistrarBaixa_Load);
            this.gpbSelecionar.ResumeLayout(false);
            this.gpbSelecionar.PerformLayout();
            this.gpbSelecionado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListView ltvRegBaixaSelecionar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView ltvRegBaixaSelecionado;
        private System.Windows.Forms.TextBox txbPesquisa;
        private System.Windows.Forms.Button bntConfirmar;
        private System.Windows.Forms.GroupBox gpbSelecionar;
        private System.Windows.Forms.GroupBox gpbSelecionado;
    }
}