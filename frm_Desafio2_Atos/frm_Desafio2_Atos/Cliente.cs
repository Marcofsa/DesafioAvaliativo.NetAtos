
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frm_Desafio2_Atos
{
    internal class Cliente
    {
        public int id;
        public string nome;
        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();
            SqlTransaction transacao = cn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = cn;
            com.Transaction = transacao;
            com.CommandType = CommandType.Text;
            com.CommandText = "insert into Tbcliente(nome_cliente) values (@nome_cliente);";
            com.Parameters.Add("@nome_cliente", SqlDbType.VarChar);
            com.Parameters[0].Value = nome;
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
