namespace frm_Desafio2_Atos
{
    partial class frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.botao_Cad_Prod = new System.Windows.Forms.Button();
            this.botao_Pg_Cliente = new System.Windows.Forms.Button();
            this.botao_Cad_Forn = new System.Windows.Forms.Button();
            this.botao_Vendas = new System.Windows.Forms.Button();
            this.botao_Relatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botao_Cad_Prod
            // 
            this.botao_Cad_Prod.Location = new System.Drawing.Point(131, 156);
            this.botao_Cad_Prod.Name = "botao_Cad_Prod";
            this.botao_Cad_Prod.Size = new System.Drawing.Size(130, 67);
            this.botao_Cad_Prod.TabIndex = 1;
            this.botao_Cad_Prod.Text = "Cadastrar Produtos";
            this.botao_Cad_Prod.UseVisualStyleBackColor = true;
            this.botao_Cad_Prod.Click += new System.EventHandler(this.botao_Cad_Prod_Click);
            // 
            // botao_Pg_Cliente
            // 
            this.botao_Pg_Cliente.Location = new System.Drawing.Point(340, 156);
            this.botao_Pg_Cliente.Name = "botao_Pg_Cliente";
            this.botao_Pg_Cliente.Size = new System.Drawing.Size(130, 67);
            this.botao_Pg_Cliente.TabIndex = 2;
            this.botao_Pg_Cliente.Text = "Cadastrar Clientes";
            this.botao_Pg_Cliente.UseVisualStyleBackColor = true;
            this.botao_Pg_Cliente.Click += new System.EventHandler(this.botao_Cad_Cliente_Click);
            // 
            // botao_Cad_Forn
            // 
            this.botao_Cad_Forn.Location = new System.Drawing.Point(549, 156);
            this.botao_Cad_Forn.Name = "botao_Cad_Forn";
            this.botao_Cad_Forn.Size = new System.Drawing.Size(130, 67);
            this.botao_Cad_Forn.TabIndex = 3;
            this.botao_Cad_Forn.Text = "Cadastrar Fornecedores";
            this.botao_Cad_Forn.UseVisualStyleBackColor = true;
            this.botao_Cad_Forn.Click += new System.EventHandler(this.botao_Cad_Forn_Click);
            // 
            // botao_Vendas
            // 
            this.botao_Vendas.Location = new System.Drawing.Point(340, 264);
            this.botao_Vendas.Name = "botao_Vendas";
            this.botao_Vendas.Size = new System.Drawing.Size(130, 67);
            this.botao_Vendas.TabIndex = 4;
            this.botao_Vendas.Text = "Vender";
            this.botao_Vendas.UseVisualStyleBackColor = true;
            this.botao_Vendas.Click += new System.EventHandler(this.botao_Vendas_Click);
            // 
            // botao_Relatorio
            // 
            this.botao_Relatorio.Location = new System.Drawing.Point(539, 376);
            this.botao_Relatorio.Name = "botao_Relatorio";
            this.botao_Relatorio.Size = new System.Drawing.Size(203, 102);
            this.botao_Relatorio.TabIndex = 5;
            this.botao_Relatorio.Text = "Relatório";
            this.botao_Relatorio.UseVisualStyleBackColor = true;
            this.botao_Relatorio.Click += new System.EventHandler(this.botao_Relatorio_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.botao_Relatorio);
            this.Controls.Add(this.botao_Vendas);
            this.Controls.Add(this.botao_Cad_Forn);
            this.Controls.Add(this.botao_Pg_Cliente);
            this.Controls.Add(this.botao_Cad_Prod);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion
        private Button botao_Cad_Prod;
        private Button botao_Pg_Cliente;
        private Button botao_Cad_Forn;
        private Button botao_Vendas;
        private Button botao_Relatorio;
    }
}