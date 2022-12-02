namespace Atos_ProjetoFinal
{
    partial class frmBiblioteca
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxPlataforma = new System.Windows.Forms.TextBox();
            this.dataGridBiblioteca = new System.Windows.Forms.DataGridView();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.botaoMostrar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CATEGORIA: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "PLATAFORMA: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "BIBLIOTECA DE ORGANIZAÇÃO:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(105, 58);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(181, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(105, 101);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(181, 23);
            this.textBoxCategoria.TabIndex = 5;
            // 
            // textBoxPlataforma
            // 
            this.textBoxPlataforma.Location = new System.Drawing.Point(105, 145);
            this.textBoxPlataforma.Name = "textBoxPlataforma";
            this.textBoxPlataforma.Size = new System.Drawing.Size(181, 23);
            this.textBoxPlataforma.TabIndex = 6;
            // 
            // dataGridBiblioteca
            // 
            this.dataGridBiblioteca.AllowUserToAddRows = false;
            this.dataGridBiblioteca.AllowUserToDeleteRows = false;
            this.dataGridBiblioteca.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBiblioteca.Location = new System.Drawing.Point(309, 58);
            this.dataGridBiblioteca.Name = "dataGridBiblioteca";
            this.dataGridBiblioteca.ReadOnly = true;
            this.dataGridBiblioteca.RowTemplate.Height = 25;
            this.dataGridBiblioteca.Size = new System.Drawing.Size(479, 235);
            this.dataGridBiblioteca.TabIndex = 7;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(105, 186);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(92, 42);
            this.botaoCadastrar.TabIndex = 8;
            this.botaoCadastrar.Text = "CADASTRAR";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.botaoCadastrar_Click);
            // 
            // botaoMostrar
            // 
            this.botaoMostrar.Location = new System.Drawing.Point(309, 299);
            this.botaoMostrar.Name = "botaoMostrar";
            this.botaoMostrar.Size = new System.Drawing.Size(92, 42);
            this.botaoMostrar.TabIndex = 9;
            this.botaoMostrar.Text = "MOSTRAR";
            this.botaoMostrar.UseVisualStyleBackColor = true;
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(407, 299);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(92, 42);
            this.botaoExcluir.TabIndex = 10;
            this.botaoExcluir.Text = "EXCLUIR";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            // 
            // frmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoMostrar);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.dataGridBiblioteca);
            this.Controls.Add(this.textBoxPlataforma);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBiblioteca";
            this.Text = "BIBLIOTECA ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBiblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNome;
        private TextBox textBoxCategoria;
        private TextBox textBoxPlataforma;
        private DataGridView dataGridBiblioteca;
        private Button botaoCadastrar;
        private Button botaoMostrar;
        private Button botaoExcluir;
    }
}