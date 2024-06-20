using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
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
    public class ItemBudgetDAO
    {
        private static MySqlConnection _connection;
        public ItemBudgetDAO() 
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra os itens do orçamento no banco de dados
        /// </summary>
        /// <param name="obj">Objeto Item do orçamento</param>
        public static void Insert(ItemBudget obj)
        {
            try
            {
                new ItemBudgetDAO();
                string sql = "INSERT INTO item_budget (cod_budget, cod_severce, price, amount, subtotal) VALUE (@cod_budget, @cod_severce, @amount, @price, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_budget", obj.CodBudget);
                cmd.Parameters.AddWithValue("@cod_severce", obj.CodSeverce);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

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
        /// <summary>
        /// Atualiza os itens do orçamento
        /// </summary>
        /// <param name="obj">Objeto item orçamento</param>
        public static void UpData(ItemBudget obj)
        {
            try
            {
                new ItemBudgetDAO();
                string sql = "UPDATE item_budget SET amount=@amount, price=@price, subtotal=@subtotal WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_severce", obj.CodSeverce);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@price", obj.Price);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

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
        /// <summary>
        /// Deleta os itens do orçamento do banco de dados
        /// </summary>
        /// <param name="cod">Código do orçamento</param>
        public static void Delete(int cod)
        {
            try
            {
                new ItemBudgetDAO();
                string sql = "DELETE item_budget cod_budget WHERE @cod_budget";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_budget", cod);
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
        /// <summary>
        /// Consulta os itens de um orçamento no banco de dados
        /// </summary>
        /// <param name="cod">código do orçamento</param>
        /// <returns></returns>
        public static DataTable GetConsult(int cod)
        {
            try
            {
                new ItemBudgetDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM item_budget cod_budget WHERE @cod_budget";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_budget", cod);

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
