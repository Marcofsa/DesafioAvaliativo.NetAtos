
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;

namespace frm_Desafio2_Atos
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";
        private void botao_Cad_Prod_Click(object sender, EventArgs e)
        {

            frm_Produto frm_prod = new frm_Produto();            
            frm_prod.Show();
            this.Hide();
        }
        private void botao_Cad_Cliente_Click(object sender, EventArgs e)
        {
            frm_Clientes cliente = new frm_Clientes();
            cliente.Show();
            this.Hide();
        }
        private void botao_Cad_Forn_Click(object sender, EventArgs e)
        {
            frm_Fornecedores forn = new frm_Fornecedores();
            forn.Show();
            this.Hide();
        }
        private void botao_Vendas_Click(object sender, EventArgs e)
        {
            frm_Vendas vendas = new frm_Vendas();
            vendas.Show();
            this.Hide();
        }
        private void botao_Relatorio_Click(object sender, EventArgs e)
        {
            frm_Relatorio rel = new frm_Relatorio();
            rel.Show();
            this.Hide();
        }
    }
}