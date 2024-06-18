using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class ClienteDAO
    {
        private static MySqlConnection _connection;

        public ClienteDAO() 
        { 
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert into
        /// <summary>
        /// Cadastrar <nameof>Cliente</nameof> no banco de dados
        /// </summary>
        /// <param name="obj"></param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void Insert(Client obj)
        {
            try
            {
                new ClienteDAO();
                string sql = @"insert into bdholerite.tb_cliente(name, cpf, num_phone, email, logradouro, home_num, bairro, cep, city) 
                value (@name, @cpf, @num_phone, @email, @logradouro, @home_num, @bairro, @cep, @city)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@num_phone", obj.NumPhone);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@logradouro", obj.Logradouro);
                cmd.Parameters.AddWithValue("@home_num", obj.HomeNum);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@city", obj.City);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O funcionário {obj.Name} foi cadastrado");

            }
            catch (Exception ex)
            {
                throw new NullReferenceException("Algo de errado!");
                throw new ArgumentException("Por favor, verifique se todos os campos obrigatorios estão preenchidos");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o cliente
        /// </summary>
        /// <param name="id">Id do cliente</param>
        public static void Delete(int id)
        {
            try
            {
                new ClienteDAO();
                string sql = "delete from tb_cliente where id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("O Cliente foi deletado");

            }catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Update
        /// <summary>
        /// UpDate do Cliente
        /// </summary>
        /// <param name="obj"></param>
        public static void UpDate(Cliente obj)
        {
            try
            {
                new ClienteDAO();
                string sql = @"update bdholerite.tb_funcionario (name=@name, cpf=@cpf,num_phone=@num_phone, emial=@emial, 
                logradouro=@logradouro, home_num=@home_num, bairro=@bairro, cep=@cep, city=@city";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@num_phone", obj.NumPhone);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@logradouro", obj.Logradouro);
                cmd.Parameters.AddWithValue("@home_num", obj.HomeNum);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@city", obj.City);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O funcionário {obj.Name} foi cadastrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");            
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consultar os clientes no banco de dados
        /// </summary>
        /// <returns>DataTable com as informações do cliente</returns>
        public static DataTable Consult()
        {
            try
            {
                new ClienteDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_client";

                _connection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }

        }
        #endregion

        #region ConsultName
        public static DataTable Consult(string name)
        {
            try
            {
                new ClienteDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_client name like @name";

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
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Bucar
        public static DataTable Buscar(string name)
        {
            try
            {
                new ClienteDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_client name where @name";

                MySqlCommand cmd = new MySqlCommand(sql,_connection);
                cmd.Parameters.AddWithValue("@name", name);
                _connection.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Clone(); }
        }
        #endregion
    }
}
