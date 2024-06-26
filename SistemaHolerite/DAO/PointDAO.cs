using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
        /// <summary>
        /// Cadastra o cabeçario do ponto no banco de dados
        /// </summary>
        /// <param name="obj">Informações do ponto</param>
        public static void InsetIndo(MODEL.Point obj)
        {
            try
            {
                new PointDAO();
                string sql = @"INSERT INDO point(cod_company, cod_emp)
                value(@cod_company, @cod_emp)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod_company", obj.CodCom);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                
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
        /// <summary>
        /// Deleta o ponto do banco de dados
        /// </summary>
        /// <param name="cod">codigo do ponto</param>
        public static void Delete(int cod)
        {
            try
            {
                new PointDAO();
                string sql = "DELETE point WHERE cod=@cod";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

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
        /// <summary>
        /// Traz o ultimo ponto do banco de dados
        /// </summary>
        /// <returns></returns>
        public static int GetEnd()
        {
            try
            {
                new PointDAO();
                int cod = 0;
                string sql = "SELECT MAX(cod) FROM point";
                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                
                _connection.Open();
                
                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    cod = dr.GetInt16("cod");
                }
                else
                {
                    Dialogo.Message("ATENÇÃO", $"Ponto não encontrado! Verifique a conexão com o banco de dados!");
                }

                return cod;
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
        /// <summary>
        /// Busca os pontos de acordo com a data de inicio e fim
        /// </summary>
        /// <param name="dataStart">Data inicio</param>
        /// <param name="dataStart">Data fim</param>
        /// <returns></returns>
        public static DataTable GetData(DateTime dataStart, DateTime dataEnd)
        {
            DataTable dt = new DataTable();
            try
            {
                new PointDAO();
                string sql = @"SELECT 
	            c.name as 'Nome Empresa',
	            c.fantasy_name as 'Nome Fantasia', 
	            c.city as 'Cidade',
	            u.emp_name as 'Nome Funcionário',
	            u.emp_function as 'Função'
	            FROM point as p 
	            JOIN user_employee as u on (p.cod_emp = u.cod)
	            JOIN company as c on (p.cod_company = c.cod)
	            JOIN item_point as i on (p.cod = i.cod_point)
	            WHERE i.date_point between @data_start and @data_end";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@data_start", dataStart);
                cmd.Parameters.AddWithValue("@data_end", dataEnd);

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

        #region GetNameConsult
        /// <summary>
        /// Consulta o ponto de acordo com o nome do funcionário
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable GetNameConsult(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                new PointDAO();
                string sql = @"LECT i.date_point as 'Data',
                u.emp_name as 'Nome Funcionário',
                u.emp_function as 'Função'
                FROM point as p 
                JOIN user_employee as u on (p.cod_emp = u.cod)
                JOIN company as c on (p.cod_company = c.cod)
                JOIN item_point as i on (p.cod = i.cod_point) 
                WHERE u.emp_name LIKE @name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

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

        #region GetSearchName
        /// <summary>
        /// Busca o ponto do funcionário pelo nome
        /// </summary>
        /// <param name="name">Nome do Funcionário</param>
        /// <returns></returns>
        public static DataTable GetSearchName(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                new PointDAO();

                string sql = @"SELECT i.date_holerite as 'Data',
                u.emp_name as 'Nome Funcionário',
                u.emp_function as 'Função'
                FROM holerite as p 
                JOIN user_employee as u on (p.cod_emp = u.cod)
                JOIN company as c on (p.cod_company = c.cod)
                JOIN item_holerite as i on (p.cod = i.cod_point) 
                WHERE u.emp_name = @name";

                MySqlCommand cmd = new MySqlCommand(sql,_connection);
                cmd.Parameters.AddWithValue("@name", name);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}"); 
                return null;
            }
        }
        #endregion
    }
}