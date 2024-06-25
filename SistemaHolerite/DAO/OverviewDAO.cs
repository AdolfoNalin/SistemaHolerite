using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class OverviewDAO
    {
        private static MySqlConnection _connection;

        public OverviewDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o resumo geral do ponto no banco de dados
        /// </summary>
        /// <param name="obj">Objeto resumo geral</param>
        public static void Insert(Overview obj)
        {
            try
            {
                string sql = @"INSERT INTO overveiw(cod_point, time_work, extra_time, missing_month, subtotal, inss, others_des, wage_fam, trl, 
                visa_inspection
                VALAUE(@cod_point, @time_work, @extra_time, @missing_month, @subtotal, @inss, @others_des, @wage_fam, @trl, @visa_inspection)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_point", obj.CodPonto);
                cmd.Parameters.AddWithValue("@time_work", obj.Time);
                cmd.Parameters.AddWithValue("@extra_time", obj.MissingMoth);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@inss", obj.INSS);
                cmd.Parameters.AddWithValue("@others_des", obj.OthersDes);
                cmd.Parameters.AddWithValue("@wage_fam", obj.WageFam);
                cmd.Parameters.AddWithValue("@trl", obj.TLR);
                cmd.Parameters.AddWithValue("@visa_inspection", obj.VisaInspection);

                _connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o camìnho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Consult cod point
        /// <summary>
        /// Consulta o resumo geral baseado no código do ponto
        /// </summary>
        /// <param name="cod_point">código do ponto</param>
        /// <returns></returns>
        public static DataTable Consult(int cod_point)
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELCT * FROM overview WHERE cod_point=@cod_point";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_point", cod_point);

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
            finally
            {
                _connection.Close();
            }
        }
        #endregion
    }
}
