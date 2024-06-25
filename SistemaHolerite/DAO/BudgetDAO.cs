using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Bcpg.OpenPgp;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class BudgetDAO
    {
        private static MySqlConnection _connection;

        public BudgetDAO()
        {
            _connection = new ConnectionFactory().GetConnection();    
        }

        #region Insert
        /// <summary>
        /// Cadastrar o orçamento no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public static void Indo(Budget obj)
        {
            try
            {
                new BudgetDAO();
                string sql = @"INSERT INDO budget (cod_client, cod_emp, payment, subtotal, total
                VALUES(@cod_client, @cod_emp, @payment, @subtotal, @total";

                MySqlCommand cmd = new MySqlCommand(sql, _connection); 
                cmd.Parameters.AddWithValue("@cod_client", obj.CodClient);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@payment", obj.Payment);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@total", obj.Total);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O orçamento foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region UpDate
        /// <summary>
        /// Atualizar os dados do orçamento
        /// </summary>
        /// <param name="obj"></param>
        public static void UpDate(Budget obj)
        {
            try
            {
                new BudgetDAO();
                string sql = "UPDATE budget(id_cliente=@id_cliente, id_fun=@id_fun, dp=@dp, subtotal=@subtotal, total=@total)";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod_client", obj.CodClient);
                cmd.Parameters.AddWithValue("@cod_emp", obj.CodEmp);
                cmd.Parameters.AddWithValue("@payment", obj.Payment);
                cmd.Parameters.AddWithValue("@date", obj.Date);
                cmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);
                cmd.Parameters.AddWithValue("@total", obj.Total);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O orçamento foi editado com sucesso!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o orçamento do banco de dados
        /// </summary>
        /// <param name="cod">código do orçamento</param>
        public static void Delete(int cod)
        {
            try
            {
                new BudgetDAO();
                string sql = "DELETE budget cod WHERE @cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Orçamento foi deletado com sucesso!");
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

        #region Consult
        /// <summary>
        /// Consulta os dados do banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult()
        {
            try
            {
                new BudgetDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM budget";

                MySqlDataAdapter da = new MySqlDataAdapter(sql,_connection);
                _connection.Open();
                da.Fill(dt);

                return dt;

            }catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region ConsultName
        /// <summary>
        /// Consulta os dados do banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult(string name)
        {
            try
            {
                new BudgetDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM budget WHERE name Like @name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                MySqlDataAdapter da = new MySqlDataAdapter(sql, _connection);
                _connection.Open();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region SearchName
        /// <summary>
        /// Busca os dados do banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable SearchName(string name)
        {
            try
            {
                new BudgetDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM budget WHERE name = @name";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", name);

                MySqlDataAdapter da = new MySqlDataAdapter(sql, _connection);
                _connection.Open();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region SwarchDate
        /// <summary>
        /// Busca os dados do orçamento baseado na data inicio e na data fim
        /// </summary>
        /// <param name="startDate">Data inicio</param>
        /// <param name="endDate">Data Fim</param>
        /// <returns></returns>
        public static DataTable GetSeachDate(DateTime startDate, DateTime endDate)
        {
            try
            {
                new BudgetDAO();
                DataTable dt = new DataTable();

                string sql = @"SELECT o.id AS 'Código',
                c.nome AS 'Cliente',
                f.nome AS 'Vendedor',
                b.subtotal AS 'Subtotal',
                b.total AS 'Total',
                b.date AS 'Data da Orçamento',
                b.observation AS 'Observações' 
                from budget AS b
                JOIN client AS c ON (b.codClient = c.cod)
                JOIN user_employee as f ON (o.cod_emp = f.cod)
                WHERE o.date BETWEEN @startDate AND @endDate";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu ume erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally {_connection.Close(); }
        }
        #endregion

        #region UltimoOrcamento
        /// <summary>
        /// Retorna o Ultimo orçamento do banco de dados
        /// </summary>
        /// <returns></returns>
        public static int EndOrcamento()
        {
            int id = 0;
            try
            {
                string sql = "SELECT MAX(cod) cod FROM budget";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32("cod");
                }
                else
                {
                    MessageBox.Show($"Verifique a conexão com o banco de dados");
                }

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return 0;
            }
        }
        #endregion
    }
}
