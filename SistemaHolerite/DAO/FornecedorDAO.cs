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
    public class FornecedorDAO
    {
        private static MySqlConnection _connection;
        public FornecedorDAO() 
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        public static void Insert(Fornecedor obj)
        {
            try
            {
                new Fornecedor();
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
                Dialogo.Message("SUCESSO!",$"O fornecedor {obj.Name} foi cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Consult
        public static DataTable Consult()
        {
            try
            {
                new FornecedorDAO();
                DataTable dt = new DataTable();

                string sql = "Select * form tb_fornecedor";

                _connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
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
