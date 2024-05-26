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
        public static void Insert(Holerite obj)
        {
            try
            {
                string sql = @"INSERT INDO tb_holerite () 
                values()";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);

                _connection.Open();

                cmd.ExecuteNonQuery();

                Dialogo.Message("Cadastro", "Holerite foi cadastro com sucesso!");
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
        public static void Update(Holerite obj)
        {
            try
            {
                string sql = "UPDATE tb_holerite()";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);
                cmd.Parameters.AddWithValue("", obj);

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
        public static void Delete(int id)
        {
            try
            {
                string sql = "Delete from tb_holerite where id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

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
        public static DataTable Consult()
        {
            try
            {
                new HoleriteDAO();
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_holerite";

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
        public static DataTable Consult(string name)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_holerite where name=@name";

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
        public static DataTable Buscar(string name)
        {
            name = "%" + name + "%"; 
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT * FROM tb_holerite name like @name";

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
        public static int EndHolerite()
        {
            int id = 0;
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT max(id) id FROM tb_holerite";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32("id");
                }
                else
                {
                    MessageBox.Show($"");
                }

                return id;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Código {id} não conrrespondete a um holerite no banco de dados");
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
