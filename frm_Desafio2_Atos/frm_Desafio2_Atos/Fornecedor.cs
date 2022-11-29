
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos
{
    internal class Fornecedor
    {
        public int id;
        public string fornecedor;
        public int id_pedido;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Tbfornecedores(nome_fornecedor, idProduto) values (@nome_fornecedor, @idProduto);";
            com.Parameters.Add("@nome_fornecedor", SqlDbType.VarChar);
            com.Parameters.Add("@idProduto", SqlDbType.Int);
            com.Parameters[0].Value = fornecedor;
            com.Parameters[1].Value = id_pedido;

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
