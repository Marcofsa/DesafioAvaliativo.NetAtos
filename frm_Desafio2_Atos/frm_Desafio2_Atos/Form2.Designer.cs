namespace frm_Desafio2_Atos
{
    partial class frm_Clientes
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
            this.textBox_NomeCliente = new System.Windows.Forms.TextBox();
            this.grid_Cliente = new System.Windows.Forms.DataGridView();
            this.botao_CadCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botao_Voltar = new System.Windows.Forms.Button();
            this.botao_buscaCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // textBox_NomeCliente
            // 
            this.textBox_NomeCliente.Location = new System.Drawing.Point(196, 12);
            this.textBox_NomeCliente.Name = "textBox_NomeCliente";
            this.textBox_NomeCliente.Size = new System.Drawing.Size(418, 23);
            this.textBox_NomeCliente.TabIndex = 1;
            // 
            // grid_Cliente
            // 
            this.grid_Cliente.AllowUserToAddRows = false;
            this.grid_Cliente.AllowUserToDeleteRows = false;
            this.grid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Cliente.Location = new System.Drawing.Point(108, 155);
            this.grid_Cliente.Name = "grid_Cliente";
            this.grid_Cliente.ReadOnly = true;
            this.grid_Cliente.RowTemplate.Height = 25;
            this.grid_Cliente.Size = new System.Drawing.Size(558, 266);
            this.grid_Cliente.TabIndex = 2;
            // 
            // botao_CadCliente
            // 
            this.botao_CadCliente.Location = new System.Drawing.Point(196, 41);
            this.botao_CadCliente.Name = "botao_CadCliente";
            this.botao_CadCliente.Size = new System.Drawing.Size(100, 39);
            this.botao_CadCliente.TabIndex = 3;
            this.botao_CadCliente.Text = "Cadastrar";
            this.botao_CadCliente.UseVisualStyleBackColor = true;
            this.botao_CadCliente.Click += new System.EventHandler(this.botao_CadCliente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // botao_Voltar
            // 
            this.botao_Voltar.Location = new System.Drawing.Point(514, 41);
            this.botao_Voltar.Name = "botao_Voltar";
            this.botao_Voltar.Size = new System.Drawing.Size(100, 39);
            this.botao_Voltar.TabIndex = 6;
            this.botao_Voltar.Text = "Voltar";
            this.botao_Voltar.UseVisualStyleBackColor = true;
            this.botao_Voltar.Click += new System.EventHandler(this.botao_Voltar_Click);
            // 
            // botao_buscaCliente
            // 
            this.botao_buscaCliente.Location = new System.Drawing.Point(302, 41);
            this.botao_buscaCliente.Name = "botao_buscaCliente";
            this.botao_buscaCliente.Size = new System.Drawing.Size(100, 39);
            this.botao_buscaCliente.TabIndex = 7;
            this.botao_buscaCliente.Text = "Consultar";
            this.botao_buscaCliente.UseVisualStyleBackColor = true;
            this.botao_buscaCliente.Click += new System.EventHandler(this.botao_buscaCliente_Click);
            // 
            // frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::frm_Desafio2_Atos.Properties.Resources.thumb_1920_6172701;
            this.ClientSize = new System.Drawing.Size(754, 490);
            this.Controls.Add(this.botao_buscaCliente);
            this.Controls.Add(this.botao_Voltar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botao_CadCliente);
            this.Controls.Add(this.grid_Cliente);
            this.Controls.Add(this.textBox_NomeCliente);
            this.Controls.Add(this.label1);
            this.Name = "frm_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_NomeCliente;
        private DataGridView grid_Cliente;
        private Button botao_CadCliente;
        private Button button2;
        private Button botao_Voltar;
        private Button botao_buscaCliente;
    }
}