using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class ItemHoleriteDAO
    {
        private static MySqlConnection _connection;

        public ItemHoleriteDAO()
        { 
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert Into
        /// <summary>
        /// Cadastra os itens do holerite no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public static void Insert(ItemHolerite obj)
        {
            try
            {
                string sql = @"INSERT INTO item_holerite(cod_holerite, cod_attributes, description, reference, earnings, discount, total_earnings, total_discount
                VALUE (@cod_holerite, @cod_attributes, @descrition, @reference, @earnings, @discount, @total_earnings, @total_discount";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_holerite", obj.CodHolerite);
                cmd.Parameters.AddWithValue("@cod_attributes", obj.CodAttributes);
                cmd.Parameters.AddWithValue("@description", obj.Description);
                cmd.Parameters.AddWithValue("@reference", obj.Reference);
                cmd.Parameters.AddWithValue("@earnings", obj.Earnings);
                cmd.Parameters.AddWithValue("@discount", obj.Discount);
                cmd.Parameters.AddWithValue("@total_earnings", obj.TotalEarnings);
                cmd.Parameters.AddWithValue("@total_discount", obj.TotalDiscount);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region consult
        /// <summary>
        /// Consulta todos os elementos da tabela item_holerite no banco de dados
        /// </summary>
        /// <returns>Os dados da table item_holerite</returns>
        public static DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM item_holerite";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Open(); } 
        }
        #endregion

        #region Search cod holerite
        /// <summary>
        /// Procura os itens do holerite no banco de dados
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public static DataTable Search(int cod)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM item_holerite WHERE cod=@cod";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Open(); }
        }
        #endregion
    }
}
