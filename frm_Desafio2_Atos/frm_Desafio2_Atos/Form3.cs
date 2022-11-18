using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace frm_Desafio2_Atos
{
    public partial class frm_Produto : Form
    {
        public frm_Produto()
        {
            InitializeComponent();
        }
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            frm_Principal frm_inicio = new frm_Principal();
            frm_inicio.Show();
            this.Hide();
        }

        private void botao_AddProd_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.nome_prod = textBox_NomeProd.Text;
            p.valor_prod = textBox_Valor.Value;

            if (String.IsNullOrEmpty(p.nome_prod))
            {
                MessageBox.Show("É necessário informar um produto para ser cadastrado.");
            }
            else
            {
                if (p.gravar())
                {
                    MessageBox.Show("Produto e preço cadastrados!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o produto.");
                }
            }
        }

        private void botao_buscaProduto_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbproduto");
            grid_Produto.DataSource = dt;
        }
    }
    
}
