namespace frm_Desafio2_Atos
{
    partial class frm_Fornecedores
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Fornecedor = new System.Windows.Forms.TextBox();
            this.grid_Produto = new System.Windows.Forms.DataGridView();
            this.botao_CadFornecedor = new System.Windows.Forms.Button();
            this.botao_ExcluirFornecedor = new System.Windows.Forms.Button();
            this.botao_Voltar = new System.Windows.Forms.Button();
            this.botao_buscaFornecedor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_MostraFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor:";
            // 
            // textBox_Fornecedor
            // 
            this.textBox_Fornecedor.Location = new System.Drawing.Point(204, 28);
            this.textBox_Fornecedor.Name = "textBox_Fornecedor";
            this.textBox_Fornecedor.Size = new System.Drawing.Size(353, 23);
            this.textBox_Fornecedor.TabIndex = 1;
            this.textBox_Fornecedor.TextChanged += new System.EventHandler(this.textBox_Fornecedor_TextChanged);
            // 
            // grid_Produto
            // 
            this.grid_Produto.AllowUserToAddRows = false;
            this.grid_Produto.AllowUserToDeleteRows = false;
            this.grid_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Produto.Location = new System.Drawing.Point(122, 107);
            this.grid_Produto.MultiSelect = false;
            this.grid_Produto.Name = "grid_Produto";
            this.grid_Produto.ReadOnly = true;
            this.grid_Produto.RowTemplate.Height = 25;
            this.grid_Produto.Size = new System.Drawing.Size(435, 120);
            this.grid_Produto.TabIndex = 4;
            // 
            // botao_CadFornecedor
            // 
            this.botao_CadFornecedor.Location = new System.Drawing.Point(561, 64);
            this.botao_CadFornecedor.Name = "botao_CadFornecedor";
            this.botao_CadFornecedor.Size = new System.Drawing.Size(100, 39);
            this.botao_CadFornecedor.TabIndex = 5;
            this.botao_CadFornecedor.Text = "Cadastrar Fornecedor";
            this.botao_CadFornecedor.UseVisualStyleBackColor = true;
            this.botao_CadFornecedor.Click += new System.EventHandler(this.botao_CadFornecedor_Click);
            // 
            // botao_ExcluirFornecedor
            // 
            this.botao_ExcluirFornecedor.Location = new System.Drawing.Point(463, 300);
            this.botao_ExcluirFornecedor.Name = "botao_ExcluirFornecedor";
            this.botao_ExcluirFornecedor.Size = new System.Drawing.Size(100, 39);
            this.botao_ExcluirFornecedor.TabIndex = 6;
            this.botao_ExcluirFornecedor.Text = "Excluir";
            this.botao_ExcluirFornecedor.UseVisualStyleBackColor = true;
            this.botao_ExcluirFornecedor.Click += new System.EventHandler(this.botao_ExcluirFornecedor_Click);
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(613, 424);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(100, 39);
            this.botao_Voltar.TabIndex = 9;
            this.botao_Voltar.Text = "Voltar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // botao_buscaFornecedor
            // 
            this.botao_buscaFornecedor.Location = new System.Drawing.Point(128, 300);
            this.botao_buscaFornecedor.Name = "botao_buscaFornecedor";
            this.botao_buscaFornecedor.Size = new System.Drawing.Size(100, 39);
            this.botao_buscaFornecedor.TabIndex = 10;
            this.botao_buscaFornecedor.Text = "Consultar";
            this.botao_buscaFornecedor.UseVisualStyleBackColor = true;
            this.botao_buscaFornecedor.Click += new System.EventHandler(this.botao_buscaFornecedor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selecione o produto:";
            // 
            // grid_MostraFornecedores
            // 
            this.grid_MostraFornecedores.AllowUserToAddRows = false;
            this.grid_MostraFornecedores.AllowUserToDeleteRows = false;
            this.grid_MostraFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_MostraFornecedores.Location = new System.Drawing.Point(128, 345);
            this.grid_MostraFornecedores.MultiSelect = false;
            this.grid_MostraFornecedores.Name = "grid_MostraFornecedores";
            this.grid_MostraFornecedores.ReadOnly = true;
            this.grid_MostraFornecedores.RowTemplate.Height = 25;
            this.grid_MostraFornecedores.Size = new System.Drawing.Size(435, 133);
            this.grid_MostraFornecedores.TabIndex = 12;
            // 
            // frm_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frm_Desafio2_Atos.Properties.Resources.thumb_1920_6172701;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.grid_MostraFornecedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botao_buscaFornecedor);
            this.Controls.Add(this.botao_Voltar);
            this.Controls.Add(this.botao_ExcluirFornecedor);
            this.Controls.Add(this.botao_CadFornecedor);
            this.Controls.Add(this.grid_Produto);
            this.Controls.Add(this.textBox_Fornecedor);
            this.Controls.Add(this.label1);
            this.Name = "frm_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Produto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_MostraFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_Fornecedor;
        private DataGridView grid_Produto;
        private Button botao_CadFornecedor;
        private Button botao_ExcluirFornecedor;
        private Button botao_Voltar;
        private Button botao_buscaFornecedor;
        private Label label2;
        private DataGridView grid_MostraFornecedores;
    }
}