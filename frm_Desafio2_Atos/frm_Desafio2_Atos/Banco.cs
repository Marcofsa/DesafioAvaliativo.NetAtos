
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos
{
    internal class Banco
    {
        private string conec = "Data Source=localhost;Initial Catalog=db_sistema;" + "User ID=usuario; password=senha; language=Portuguese";

        private SqlConnection cn;
        public Banco()
        {
            cn = new SqlConnection(conec);
        }
        public SqlConnection abrirConexao()
        {
            try
            {
                cn.Open();
                return cn;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
