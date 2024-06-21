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
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class SeverceDAO
    {
        static private MySqlConnection _connection;
        public SeverceDAO() 
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o serviço no banco de dados
        /// </summary>
        /// <param name="obj">Objeto</param>
        public static void Insert(Severce obj)
        {
            try
            {
                new SeverceDAO();

                string sql = @"INSERT INTO severce (short_description, full_description, cod_employee, term_price,spot_price,obs)
                VALUE (@short_description,@full_descrition, @cod_emp,@term_price,@spot_price,@obs)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", obj.BriefDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@spot_price", obj.CashPrice);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO", $"O serviço {obj.BriefDescription} foi salvo com sucesso");
            }
            catch(Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region UpDate
        /// <summary>
        /// Atualiza os dados do serviço no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public static void UpDate(Severce obj)
        {
            try
            {
                new SeverceDAO();
                string sql = @"UPDATE severce SET short_description=@short_description, full_description=@full_description, cod_employee=@cod_employee,
                spot_price=@spot-price, term_price=@term_price, obs=@obs";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", obj.BriefDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@cod_employee", obj.CodEmp);
                cmd.Parameters.AddWithValue("@spot_price", obj.CashPrice);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO", $"O serviço {obj.BriefDescription} foi Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o serviço do banco de dados
        /// </summary>
        /// <param name="cod">Código do serviço</param>
        public static void Delete(int cod)
        {
            try
            {
                new SeverceDAO();
                string sql = "DELETE severce WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO","Serviço foi deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Consult
        /// <summary>
        /// consulta todos os serviços do banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                new SeverceDAO();

                string sql = "SELECT * FROM severce";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro com o caminho {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region ConsultName
        /// <summary>
        /// Consulta o serviço pelo nome com a digitação
        /// </summary>
        /// <param name="short_description">Descrição resumida</param>
        /// <returns></returns>
        public static DataTable Consult(string short_description )
        {
            try
            {
                new SeverceDAO();
                short_description = Dialogo.LikeString(short_description);

                DataTable dt = new DataTable();
                string sql = "SELECT * FROM severce short_description LIKE @short_description";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", short_description);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                _connection.Open();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro com o caminho {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region BuscarId
        /// <summary>
        /// Busca o serviço pelo código
        /// </summary>
        /// <param name="cod">código do produto</param>
        /// <returns></returns>
        public static Severce Buscar(int cod)
        {
            try
            {
                new SeverceDAO();
                Severce obj = new Severce();

                string sql = "SLECET * FROM severce cod where @cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    obj.BriefDescription = dr.GetString("full_description");
                    obj.CashPrice = dr.GetFloat("spot_price");
                    obj.TermPrice = dr.GetFloat("term_price)");
                }

                return obj;
            }catch(MySqlException ex)
            {
                Dialogo.Message("ATENÇÃO",$"Aconteceu um erro com a conexão!");
                return null;
            }catch(Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu erro com o caminho {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Buscar
        /// <summary>
        /// Busca o serviço pela descrição resumida
        /// </summary>
        /// <param name="short_description">Descrição do serviço</param>
        /// <returns></returns>
        public static DataTable Buscar(string short_description)
        {
            try
            {
                new SeverceDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM tb_servico short_description WHERE @short_decription";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", short_description);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
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