using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_Desafio2_Atos
{
    public partial class frm_Vendas : Form
    {
        public frm_Vendas()
        {
            InitializeComponent();
            carregarListaProd();
            carregarListaCliente();

        }
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";

        private void carregarListaProd()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbproduto");
            grid_MostraProd.DataSource = dt;
        }
        private void carregarListaCliente()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbcliente");
            grid_MostraCliente.DataSource = dt;
        }

        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            frm_Principal frm_inicio = new frm_Principal();
            frm_inicio.Show();
            this.Hide();
        }

        private void botao_GeraVenda_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();

            if (grid_MostraCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Informe um Cliente.");
            }
            else
            {
                v.idCliente = int.Parse(grid_MostraCliente.Rows[grid_MostraCliente.SelectedRows[0].Index].Cells[0].Value.ToString());
                if (grid_MostraProd.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Informe um Produto.");
                }
                else
                {
                    v.idProduto = int.Parse(grid_MostraProd.Rows[grid_MostraProd.SelectedRows[0].Index].Cells[0].Value.ToString());
                    v.valorProd = decimal.Parse(grid_MostraProd.Rows[grid_MostraProd.SelectedRows[0].Index].Cells[2].Value.ToString());
                    if (v.gravar())
                    {
                        MessageBox.Show("Venda realizada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao realizar a venda.");
                    }
                }
            }
        }

        private void botao_Consulta_Click(object sender, EventArgs e)
        {

            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbproduto");
            grid_MostraProd.DataSource = dt;
        }
    }
}
