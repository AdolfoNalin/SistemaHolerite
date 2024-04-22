using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class ItemVandaDAO
    {
        private static MySqlConnection _connection;
        public ItemVandaDAO() 
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        public static void Insert(ItemOrcamento obj)
        {
            try
            {
                new ItemVandaDAO();
                string sql = "insert into tb_itemvenda (id_orcamento, id_produto, preco) value (@id_orcamento, @id_produto, @preco)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id_orcamento", obj.IdOrcamento);
                cmd.Parameters.AddWithValue("@id_produto", obj.IdProduto);
                cmd.Parameters.AddWithValue("@preco", obj.preco);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}"); 
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region UpData
        public static void UpData(ItemOrcamento obj)
        {
            try
            {
                new ItemVandaDAO();
                string sql = "update tb_itemOrcamento (id_produto=@id_produto, qtd, preco=@preco)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id_produto", obj.IdProduto);
                cmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                cmd.Parameters.AddWithValue("@preco", obj.preco);

                _connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Delete
        public static void Delete(int id)
        {
            try
            {
                new ItemVandaDAO();
                string sql = "delete tb_itemvenda id where @id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);
                _connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Os itens foram excluidos");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        public static DataTable GetConsult(int id)
        {
            try
            {
                new ItemVandaDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_itemorcamento id_orcamento where @id_orcamento";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id_orcamento", id);

                _connection.Open();
                cmd.ExecuteNonQuery();

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
        }
        #endregion

    }
}
