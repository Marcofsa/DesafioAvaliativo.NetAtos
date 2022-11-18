namespace frm_Desafio2_Atos
{
    partial class frm_Vendas
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
            this.grid_MostraCliente = new System.Windows.Forms.DataGridView();
            this.grid_MostraProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botao_Voltar = new System.Windows.Forms.Button();
            this.botao_GeraVenda = new System.Windows.Forms.Button();
            this.botao_Consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraProd)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_MostraCliente
            // 
            this.grid_MostraCliente.AllowUserToAddRows = false;
            this.grid_MostraCliente.AllowUserToDeleteRows = false;
            this.grid_MostraCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraCliente.Location = new System.Drawing.Point(154, 100);
            this.grid_MostraCliente.Name = "grid_MostraCliente";
            this.grid_MostraCliente.ReadOnly = true;
            this.grid_MostraCliente.RowTemplate.Height = 25;
            this.grid_MostraCliente.Size = new System.Drawing.Size(396, 111);
            this.grid_MostraCliente.TabIndex = 0;
            // 
            // grid_MostraProd
            // 
            this.grid_MostraProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraProd.Location = new System.Drawing.Point(154, 239);
            this.grid_MostraProd.Name = "grid_MostraProd";
            this.grid_MostraProd.RowTemplate.Height = 25;
            this.grid_MostraProd.Size = new System.Drawing.Size(396, 111);
            this.grid_MostraProd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione ao produto:";
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(639, 414);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(103, 38);
            this.botao_Voltar.TabIndex = 4;
            this.botao_Voltar.Text = "Voltar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // botao_GeraVenda
            // 
            this.botao_GeraVenda.Location = new System.Drawing.Point(446, 356);
            this.botao_GeraVenda.Name = "botao_GeraVenda";
            this.botao_GeraVenda.Size = new System.Drawing.Size(104, 39);
            this.botao_GeraVenda.TabIndex = 5;
            this.botao_GeraVenda.Text = "Gerar venda";
            this.botao_GeraVenda.UseVisualStyleBackColor = true;
            this.botao_GeraVenda.Click += new System.EventHandler(this.botao_GeraVenda_Click);
            // 
            // botao_Consulta
            // 
            this.botao_Consulta.Location = new System.Drawing.Point(556, 239);
            this.botao_Consulta.Name = "botao_Consulta";
            this.botao_Consulta.Size = new System.Drawing.Size(97, 47);
            this.botao_Consulta.TabIndex = 6;
            this.botao_Consulta.Text = "Consulta";
            this.botao_Consulta.UseVisualStyleBackColor = true;
            this.botao_Consulta.Click += new System.EventHandler(this.botao_Consulta_Click);
            // 
            // frm_Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frm_Desafio2_Atos.Properties.Resources.thumb_1920_6172701;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.botao_Consulta);
            this.Controls.Add(this.botao_GeraVenda);
            this.Controls.Add(this.botao_Voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_MostraProd);
            this.Controls.Add(this.grid_MostraCliente);
            this.Name = "frm_Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grid_MostraCliente;
        private DataGridView grid_MostraProd;
        private Label label1;
        private Label label2;
        private Button botao_Voltar;
        private Button botao_GeraVenda;
        private Button botao_Consulta;
    }
}