
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos
{
    internal class Produto
    {

        public int id;
        public string nome_prod;
        public decimal valor_prod;
        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Tbproduto(nome_prod, valor_prod) values (@nome_prod, @valor_prod);";
            com.Parameters.Add("@nome_prod", SqlDbType.VarChar);
            com.Parameters.Add("@valor_prod", SqlDbType.Decimal);
            com.Parameters[0].Value = nome_prod;
            com.Parameters[1].Value = valor_prod;
            try
            {
                com.ExecuteNonQuery();
                transacao.Commit();
                return true;

            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return false;

            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
