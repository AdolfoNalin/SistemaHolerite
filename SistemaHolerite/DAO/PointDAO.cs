using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class PointDAO
    {
        private static MySqlConnection _connection;

        public PointDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        public static void InsetIndo(MODEL.Point obj)
        {
            try
            {
                string sql = @"INSERT INDO tb.ponto()
                values()";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@empregado", obj.Empregado.Nome);
                cmd.Parameters.AddWithValue("@funcao", obj.Empregado.Funcao);
                cmd.Parameters.AddWithValue("@mes", obj.Empregado.Mes);
                cmd.Parameters.AddWithValue("@ano", obj.Empregado.Ano);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO!", "O ponto foi cadastrar do com sucesso");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }

        }
        #endregion

        #region Delete
        public static void Delete(int id)
        {
            try
            {
                string sql = "Delete tb_ponto id where @id";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO", $"O ponto foi deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region GetEndPonto
        public static int GetEnd()
        {
            try
            {
                int id = 0;
                string sql = "SELECT MAX(id) FROM tb_ponto";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                _connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    id = dr.GetInt16("id");
                }
                else
                {
                    Dialogo.Message("ATENÇÃO", $"Ponto não encontrado! Verifique a conexão com o banco de dados!");
                }

                return id;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return 0;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region GetData
        public static MODEL.Point GetData(DateTime data)
        {
            try
            {
                MODEL.Point obj = new MODEL.Point();
                string sql = "SELECT * FROM tb_ponto WHERE data between @data";
                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@data", data);

                _connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                }
                else
                {
                    Dialogo.Message("ATENÇÃO", "Não foi possivel encontrar! Verifique a conexão com o banco de dados");
                }
                return obj;
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