
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos
{
    internal class Venda
    {
        public int id;
        public int idVenda;
        public int idProduto;
        public int idCliente;
        public decimal valorProd;
       

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Tbvendas(idProduto, idCliente, valorProd) values (@idProduto, @idCliente, @valorProd);";
            com.Parameters.Add("@idProduto", SqlDbType.Int);
            com.Parameters.Add("@idCliente", SqlDbType.Int);
            com.Parameters.Add("@valorProd", SqlDbType.Decimal);
            com.Parameters[0].Value = idProduto;
            com.Parameters[1].Value = idCliente;
            com.Parameters[2].Value = valorProd;

          
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

        public bool deletar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Tbfornecedores where idFornecedor =  @id";
            com.Parameters.Add("@id", SqlDbType.Int);
            com.Parameters[0].Value = id;

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
