using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class ItemPointDAO
    {
        private static MySqlConnection _connection;

        public ItemPointDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        public static void Insert(ItemPoint obj)
        {
            try
            {
                string sql = @"INSERT INDO tb_itemponto()
                values()";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Update
        public static void Update(ItemPointDAO obj)
        {
            try
            {
                string sql = "UPDATE SET tb_itemponto()";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);
                cmd.Parameters.AddWithValue("@", obj);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO", $"Itens foram cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");

            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
