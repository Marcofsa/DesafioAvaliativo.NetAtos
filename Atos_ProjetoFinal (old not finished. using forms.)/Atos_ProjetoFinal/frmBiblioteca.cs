using Microsoft.Data.SqlClient;

namespace Atos_ProjetoFinal
{
    public partial class frmBiblioteca : Form
    {
        public frmBiblioteca()
        {
            InitializeComponent();
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {  
            Biblioteca b =  new Biblioteca();
            b.nome = textBoxNome.Text;
            b.categoria = textBoxCategoria.Text;
            b.plataforma = textBoxPlataforma.Text;

        }
    }
}