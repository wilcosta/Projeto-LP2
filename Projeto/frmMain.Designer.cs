namespace Projeto
{
    partial class frmMain
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
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_MarcarTodos = new System.Windows.Forms.Button();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apagar.Location = new System.Drawing.Point(329, 654);
            this.btn_Apagar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(150, 35);
            this.btn_Apagar.TabIndex = 11;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(171, 654);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(150, 35);
            this.btn_Editar.TabIndex = 10;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.Location = new System.Drawing.Point(13, 654);
            this.btn_Inserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(150, 35);
            this.btn_Inserir.TabIndex = 9;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 86);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1324, 558);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descrição";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código de Barras";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unid. Medida";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantidade";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vencimento";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dias Restantes";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Observação";
            this.columnHeader8.Width = 250;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(1187, 654);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(150, 35);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.Text = "Alterar Usuário";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Imprimir.Location = new System.Drawing.Point(13, 41);
            this.btn_Imprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(150, 35);
            this.btn_Imprimir.TabIndex = 19;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_MarcarTodos
            // 
            this.btn_MarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MarcarTodos.Location = new System.Drawing.Point(171, 41);
            this.btn_MarcarTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MarcarTodos.Name = "btn_MarcarTodos";
            this.btn_MarcarTodos.Size = new System.Drawing.Size(150, 35);
            this.btn_MarcarTodos.TabIndex = 20;
            this.btn_MarcarTodos.Text = "Mostrar Todos";
            this.btn_MarcarTodos.UseVisualStyleBackColor = true;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(1029, 41);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(150, 35);
            this.btn_Pesquisar.TabIndex = 21;
            this.btn_Pesquisar.Text = "Buscar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(1187, 41);
            this.btn_Cadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(150, 35);
            this.btn_Cadastrar.TabIndex = 22;
            this.btn_Cadastrar.Text = "Cadastrar Produto";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.btn_MarcarTodos);
            this.Controls.Add(this.btn_Imprimir);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vencimentos";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Apagar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_MarcarTodos;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}