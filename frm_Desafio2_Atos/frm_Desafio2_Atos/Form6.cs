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
    public partial class frm_Relatorio : Form
    {
        public frm_Relatorio()
        {
            InitializeComponent();
        }
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";
        private void carregarListaVendas()
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbvendas");
            grid_MostraRelatorio.DataSource = dt;
        }

        private void grid_MostraRelatório_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void botao_Voltar_Click(object sender, EventArgs e)
        {
            frm_Principal frm = new frm_Principal();
            frm.Show();
            this.Hide();
        }

        private void botao_ConsultaRel_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();
            DataTable dt = new DataTable();
            dt = bd.executaConsulta("select * from Tbvendas");
            grid_MostraRelatorio.DataSource = dt;
        }
    }
}
