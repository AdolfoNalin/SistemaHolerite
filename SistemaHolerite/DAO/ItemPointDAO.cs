using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        /// <summary>
        /// Cadastra o item dos pontos no banco de dados
        /// </summary>
        /// <param name="obj">objeto itens do ponto</param>
        public static void Insert(ItemPoint obj)
        {
            try
            {
                new ItemPoint();
                string sql = @"INSERT INDO item_point(cod_point, date_point, entry_time, lunch_departure, lunch_entrance, exit_time, extra_output, extra_entry)
                values(@cod_point, @date_point, @entry_time, @lunch_departure, @lunch_entrance, @exit_time, @extra_output, @extra_entry)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_point", obj.CodPoint);
                cmd.Parameters.AddWithValue("@date_point", obj.Date);
                cmd.Parameters.AddWithValue("@entry_time", obj.EntryTime);
                cmd.Parameters.AddWithValue("@lunch_departure", obj.LunchDeparture);
                cmd.Parameters.AddWithValue("@lunch_entrance", obj.LunchEntrance);
                cmd.Parameters.AddWithValue("@exit_time", obj.ExitTime);
                cmd.Parameters.AddWithValue("@extra_output", obj.ExtraOutput);
                cmd.Parameters.AddWithValue("@extra_entry", obj.ExtraEntry);

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
        /// <summary>
        /// Atualiza da tabela item_point no banco de dados
        /// </summary>
        /// <param name="obj">Objeto itemPoint</param>
        public static void Update(ItemPoint obj)
        {
            try
            {
                string sql = @"UPDATE item_point SET 
                cod_point=@cod_point, date_time, entry_time=@entry_time, lunch_departure=@lunch_departure, lunch_entrance=@lunch_entrance, exit_time=@exit_time, extra_output=@extra_output,
                extra_entry=@extra_entry WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_point", obj.CodPoint);
                cmd.Parameters.AddWithValue("@date_point", obj.Date);
                cmd.Parameters.AddWithValue("@entry_time", obj.EntryTime);
                cmd.Parameters.AddWithValue("@lunch_departure", obj.LunchDeparture);
                cmd.Parameters.AddWithValue("@lunch_entrance", obj.LunchEntrance);
                cmd.Parameters.AddWithValue("@exit_time", obj.ExitTime);
                cmd.Parameters.AddWithValue("@extra_output", obj.ExtraOutput);
                cmd.Parameters.AddWithValue("@extra_entry", obj.ExtraEntry);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();
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

        #region SearchID
        /// <summary>
        /// Busca os itens do ponto do banco de dados
        /// </summary>
        /// <param name="codPoint">Código do ponto</param>
        /// <returns></returns>
        public static DataTable SearchId(int codPoint)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM itemPonit WHERE cod_point=@cod_point";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_point", codPoint);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion
    }
}
