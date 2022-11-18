namespace frm_Desafio2_Atos
{
    partial class frm_Relatorio
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
            this.grid_MostraRelatorio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.botao_ConsultaRel = new System.Windows.Forms.Button();
            this.botao_Voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_MostraRelatorio
            // 
            this.grid_MostraRelatorio.AllowUserToAddRows = false;
            this.grid_MostraRelatorio.AllowUserToDeleteRows = false;
            this.grid_MostraRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraRelatorio.Location = new System.Drawing.Point(84, 49);
            this.grid_MostraRelatorio.Name = "grid_MostraRelatorio";
            this.grid_MostraRelatorio.ReadOnly = true;
            this.grid_MostraRelatorio.RowTemplate.Height = 25;
            this.grid_MostraRelatorio.Size = new System.Drawing.Size(556, 139);
            this.grid_MostraRelatorio.TabIndex = 0;
            this.grid_MostraRelatorio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_MostraRelatório_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "RELATÓRIO DE VENDAS:";
            // 
            // botao_ConsultaRel
            // 
            this.botao_ConsultaRel.Location = new System.Drawing.Point(85, 194);
            this.botao_ConsultaRel.Name = "botao_ConsultaRel";
            this.botao_ConsultaRel.Size = new System.Drawing.Size(100, 42);
            this.botao_ConsultaRel.TabIndex = 2;
            this.botao_ConsultaRel.Text = "Consulta";
            this.botao_ConsultaRel.UseVisualStyleBackColor = true;
            this.botao_ConsultaRel.Click += new System.EventHandler(this.botao_ConsultaRel_Click);
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(203, 194);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(100, 42);
            this.botao_Voltar.TabIndex = 3;
            this.botao_Voltar.Text = "Voltar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // frm_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frm_Desafio2_Atos.Properties.Resources.thumb_1920_6172701;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.botao_Voltar);
            this.Controls.Add(this.botao_ConsultaRel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_MostraRelatorio);
            this.Name = "frm_Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grid_MostraRelatorio;
        private Label label1;
        private Button botao_ConsultaRel;
        private Button botao_Voltar;
    }
}