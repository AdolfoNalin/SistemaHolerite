using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
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
    public class FuncionarioDAO 
    {
        private static MySqlConnection _connection;

        public FuncionarioDAO()
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
        public static void Insert(Funcionario obj)
        {
            try
            {
                new FuncionarioDAO();
                string sql = @"insert into bdholerite.tb_funcionario(name, cpf, num_phone, email, cargo, password, logradouro, home_num, bairro, cep, city, salario,
                cargo) value (@name, @cpf, @num_phone, @email, @cargo, @password, @logradouro, @home_num, @bairro, @cep, @city, @salario, @cargo)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cpf", obj.CPF);
                cmd.Parameters.AddWithValue("@num_phone", obj.NumPhone);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                cmd.Parameters.AddWithValue("@senha", obj.Senha);
                cmd.Parameters.AddWithValue("@logradouro", obj.Logradouro);
                cmd.Parameters.AddWithValue("@home_num", obj.HomeNum);
                cmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@salario", obj.Salario);
                cmd.Parameters.AddWithValue("@cargo", obj.Cargo);

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
        public static void Delete (int id)
        {
            try
            {
                new FuncionarioDAO();
                string sql = "delete from bdholerite.tb_funcionario where id=@id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

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
        public static void UpDate(Funcionario obj)
        {
            try
            {
                new FuncionarioDAO();
                string sql = @"update bdholerite.tb_funcionario (name=@name, cpf=@cpf,num_phone=@num_phone, emial=@emial, 
logradouro=@logradouro, home_num=@home_num, bairro=@bairro, cep=@cep, city=@city, salario=@salario, cargo=@cargo, @password=password";

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
                cmd.Parameters.AddWithValue("@salario", obj.Salario);
                cmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                cmd.Parameters.AddWithValue("@password", obj.Senha);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O funcionário {obj.Name} foi cadastrado");

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
        public static DataTable Consultar()
        {
            try
            {
                new FuncionarioDAO();
                DataTable dt = new DataTable();

                string sql = @"select * from bdholerite.tb_funcionario";

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
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable Buscar(string name)
        {
            try
            {
                new FuncionarioDAO();
                DataTable dt = new DataTable();

                string sql = @"select * from bdholerite.tb_funcionario where name=@name";

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
                new FuncionarioDAO();
                name = "%" + name + "%";
                DataTable dt = new DataTable();

                string sql = @"select from bdholerite.tb_funcionario name like @name";

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
    }
}
