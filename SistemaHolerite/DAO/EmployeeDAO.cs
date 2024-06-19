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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class EmployeeDAO 
    {
        private static MySqlConnection _connection;

        public EmployeeDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastrar Funcionario no banco de dados
        /// </summary>
        /// <param name="obj">Parametro Funcionario</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void Insert(Employee obj)
        {
            try
            {
                new EmployeeDAO();
                string sql = @"INSERT INDO user_employee 
                (name, cpf, email, phone_number, telephone_number, user_name, password, state, city, neighborhood, street, home_number, cep, wage, permissions, function) 
                VALUES(@name, @cpf, @email, @phone_number, @telephone_number, @user_name, @password, @state, @city, @neighborhood, @street, home_number, @cep, @permissions, @function)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@telephone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@user_name", obj.UserName);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighbordhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@wage", obj.Wage);
                cmd.Parameters.AddWithValue("@permissions", obj.Permissions);
                cmd.Parameters.AddWithValue("@function", obj.Function);

                _connection.Open();
                cmd.ExecuteNonQuery();
                Dialogo.Message("SUCESSO!",$"O funcionário {obj.Name} foi cadastrado");
             
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
        /// Deleta o Funcionário do banco de dados
        /// </summary>
        /// <param name="cod">Código do funcionário</param>
        public static void Delete (int cod)
        {
            try
            {
                new EmployeeDAO();
                string sql = "delete from bdholerite.tb_funcionario where cod=@cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("O funcionario foi excluido com sucesso!");
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region UpDate
        /// <summary>
        /// Atualiza os dados do funcionário
        /// </summary>
        /// <param name="obj"></param>
        public static void UpDate(Employee obj)
        {
            try
            {
                new EmployeeDAO();
                string sql = @"UPDATE employee SET 
                (name=@name, cpf=@cpf, email=@email, phone_number=@phone_number, telephone_number=@telephone_number, user_name=@user_name, password=@password, 
                state=@state, city=@city, neighborhood=@neighborhood, street=@street, cep=@cep, wage=@wage, permissions=@permissions, function=@function";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@telephone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@user_name", obj.UserName);
                cmd.Parameters.AddWithValue("@password", obj.Password);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighbordhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@wage", obj.Wage);
                cmd.Parameters.AddWithValue("@permissions", obj.Permissions);
                cmd.Parameters.AddWithValue("@function", obj.Function);

                _connection.Open();
                cmd.ExecuteNonQuery();
                Dialogo.Message("SUCESSO!", $"O funcionário {obj.Name} foi cadastrado");

            }
            catch (Exception ex)
            {

                throw;
            }finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consultar
        /// <summary>
        /// Consulta os dados do funcionário
        /// </summary>
        /// <returns></returns>
        public static DataTable Consultar()
        {
            try
            {
                new EmployeeDAO();
                DataTable dt = new DataTable();

                string sql = @"SELECT * FROM employee";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, _connection);
                _connection.Open();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                _connection.Close(); 
            }
            
        }
        #endregion
        
        #region Buscar
        /// <summary>
        /// Consultar funcionario pelo nome click
        /// </summary>
        /// <param name="name">Nome do funcionário</param>
        /// <returns></returns>
        public static DataTable Buscar(string name)
        {
            try
            {
                new EmployeeDAO();
                DataTable dt = new DataTable();

                string sql = @"SELECT * FROM employee WHERE name=@name";

                MySqlCommand cmd = new MySqlCommand(sql,_connection);
                cmd.Parameters.AddWithValue("@nome", name);
                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region ConsultarNome
        /// <summary>
        /// Busca um funcionario com o nome com o evento KeyPress
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable Consultar(string name)
        {
            try
            {
                new EmployeeDAO();
                name = "%" + name + "%";
                DataTable dt = new DataTable();

                string sql = @"SELECT FROM employee name LIKE @name";

                MySqlCommand cmd = new MySqlCommand( sql,_connection);
                cmd.Parameters.AddWithValue("@name", name);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho para {ex.StackTrace}");
                return null;
            }
            finally
            {
                _connection.Open();
            }
        }
        #endregion

        #region Login
        /// <summary>
        /// Realiza a verificação do usuário no banco de dados
        /// </summary>
        /// <param name="username">Nome do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <returns></returns>
        public static bool Login(string username, string password)
        {
            try
            {
                string sql = "SELECT * FROM user_employee WHERE name = @name AND password = @password";
                
                MySqlCommand cmd = new MySqlCommand(sql,_connection);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Employee obj = new Employee()
                    {
                        UserName = dr.GetString("name"),
                        Password = dr.GetString("password")
                    };
                    return true;
                }
                else
                {
                    Dialogo.Message("ATENÇÃO", "Usuário não itendificado, virifique se os dados estão certos!");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
                return false;

            }
            finally { _connection.Close(); }
        }
        #endregion
    }
}
