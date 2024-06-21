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
    public class ClientDAO
    {
        private static MySqlConnection _connection;

        public ClientDAO() 
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
                new ClientDAO();
                string sql = @"ISERT INDO client(name, cpf, email, phone_number, telephone_number, state, city, neighborhood, street ,home_number, cep) 
                VALUES(@name, @cpf, @email, @phone_number, @telephone_number, @state, @city, @neighborhood, @streete, @cep, @city)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@telefone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighbordhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);

                _connection.Open();
                cmd.ExecuteNonQuery();
                Dialogo.Message("SUCESSO!",$"O cliente {obj.Name} foi cadastrado");

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
        /// Deleta o cliente do banco de dados
        /// </summary>
        /// <param name="cod">Código do cliente</param>
        public static void Delete(int cod)
        {
            try
            {
                new ClientDAO();
                string sql = "DELETE FROM client WHERE cod = @cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO!","O Cliente foi deletado");

            }catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO",$"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do cliente do banco de dados
        /// </summary>
        /// <param name="obj"></param>
        public static void UpDate(Client obj)
        {
            try
            {
                new ClientDAO();
                string sql = @"UPDATE client
                SET name=@name, cpf=@cpf, emial=@emial, phone_number=@phone_number, telephone_number=@telephone_number, 
                state=@state, city=@city, neighborhood=@neighborhood, street=@street, home_number, cep=@cep";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@telefone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighbordhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);

                _connection.Open();
                cmd.ExecuteNonQuery();
                Dialogo.Message("SUCESSO!",$"O funcionário {obj.Name} foi cadastrado");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO",$"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");            
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
                new ClientDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM client";

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
        /// <summary>
        /// Consulta os clientes pelo nome usanod o evento keypress
        /// </summary>
        /// <param name="name">Nome do cliente</param>
        /// <returns></returns>
        public static DataTable Consult(string name)
        {
            try
            {
                name = "%" + name + "%";
                new ClientDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM client name LIKE @name";

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
                new ClientDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM client name WHERE @name";

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
