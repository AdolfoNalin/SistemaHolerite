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
    public class HoleriteDAO
    {
        private static MySqlConnection _connection;

        public HoleriteDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o holerite no banco de dados
        /// </summary>
        /// <param name="obj">Holerite</param>
        public static void Insert(Holerite obj)
        {
            try
            {
                string sql = @"INSERT INDO holerite(sal_basic, sal_contr_inss, basic_calc_fgts, fgts_month, basic_calc_irrf, range_irrf, employee_cod, company_cod) 
                VALUES(@sal_baisc, @sal_contr_inss, @basic_calc_fgts, @fgts_month, @basic_calc_irrf, @range_irrf, @employee_cod, @company_cod)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@sal_basic", obj.BasicSal);
                cmd.Parameters.AddWithValue("@sal_contr_inss", obj.SalContrINNS);
                cmd.Parameters.AddWithValue("@basic_calc_fgts", obj.BasicCalcFGTS);
                cmd.Parameters.AddWithValue("@fgts_month", obj.FGTSMonth);
                cmd.Parameters.AddWithValue("@basic_calc_irrf", obj.BasicCalcIRRF);
                cmd.Parameters.AddWithValue("@range_irrf", obj.RangeIRRF);
                cmd.Parameters.AddWithValue("@employee_cod", obj.CodEmployee);
                cmd.Parameters.AddWithValue("@company_cod", obj.CodCompany);

                _connection.Open();

                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO!", "Holerite foi cadastro com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.DialogYesNo("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do holerite no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public static void Update(Holerite obj)
        {
            try
            {
                string sql = @"UPDATE holerite SET(company_cod=@company_cod, employee_cod=@employee_cod, sal_basic=@sal_basic, sal_contr_inss=@sal_contr_inss, 
                basic_calc_fgts=@basic_calc_fgts, fgts_month=@fgts_month, basic_calc_irrf=@basic_calc_irrf, range_irrf=@range_irrf) WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@company_cod", obj.CodCompany);
                cmd.Parameters.AddWithValue("@employee_cod", obj.CodEmployee);
                cmd.Parameters.AddWithValue("@sal_basic", obj.BasicSal);
                cmd.Parameters.AddWithValue("@sal_contr_inss", obj.SalContrINNS);
                cmd.Parameters.AddWithValue("@basic_calc_fgts", obj.BasicCalcFGTS);
                cmd.Parameters.AddWithValue("@fgts_month", obj.FGTSMonth);
                cmd.Parameters.AddWithValue("@basic_calc_irrf", obj.BasicCalcIRRF);
                cmd.Parameters.AddWithValue("@range_irrf", obj.RangeIRRF);
                cmd.Parameters.AddWithValue("@cod", obj.Cod);

                _connection.Open();
                cmd.ExecuteNonQuery();
                Dialogo.Message("ATENÇÃO", "Holerite atualizado com sucesso!");
            }
            catch(Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro {ex.Message} com caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection?.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o funcionário do banco de dados
        /// </summary>
        /// <param name="cod">Código do funcoinário</param>
        public static void Delete(int cod)
        {
            try
            {
                string sql = "DELETE FROM holerite WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();

                cmd.ExecuteNonQuery();
                Dialogo.Message("ATENÇÃO", "Holerite foi deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection?.Close(); }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta todos os holerites no banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult()
        {
            try
            {
                new HoleriteDAO();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM holerite";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally
            {
                _connection?.Close();
            }
        }
        #endregion

        #region Consult Name
        /// <summary>
        /// Consulta o holerite pelo nome do funcionário
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static DataTable Consult(string userName)
        {
            userName = Dialogo.LikeString(userName); 
            try
            {
                new HoleriteDAO();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM holerite user_name LIKE @user_name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@user_name)", userName);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally
            {
                _connection?.Close();
            }
        }
        #endregion

        #region Buscar
        /// <summary>
        /// Busca o holerite com o nome do funcionário
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static DataTable Buscar(string userName)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM holerite WHERE user_name=@user_name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@user_name", userName);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally
            {
                _connection?.Close();
            }
        }
        #endregion

        #region EndHolerite
        /// <summary>
        /// Busca o ultimo holerite cadastrado no banco de dados
        /// </summary>
        /// <returns>O ultimo código do cadastrado no banco de dados</returns>
        public static int EndHolerite()
        {
            int cod = 0;
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT max(cod) cod FROM holerite";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    cod = Convert.ToInt32("cod");
                }
                else
                {
                    MessageBox.Show($"Verifique a sua conexão com o banco de dados!");
                }

                return cod;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Código {cod} não conrrespondete a um holerite no banco de dados");
                return 0;
            }
            finally
            {
                _connection?.Close();
            }
        }
        #endregion
    }
}
