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
    public class SupplierDAO
    {
        private static MySqlConnection _connection;
        public SupplierDAO() 
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o fornecedor no banco de dados
        /// </summary>
        /// <param name="obj">Objeto do fornecedor</param>
        public static void Insert(Supplier obj)
        {
            try
            {
                new Supplier();
                string sql = @"ISERT INDO supplier(name, fantasy_name, cnpj, email, phone_number, telephone_number, state, city, neighborhood, street ,home_number, cep) 
                VALUE(@name, fantasy_name, @cnpj, @email, @phone_number, @telephone_number, @state, @city, @neighborhood, @streete, @cep, @city)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
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

                Dialogo.Message("SUCESSO!",$"O fornecedor {obj.Name} foi cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do fornecedor
        /// </summary>
        /// <param name="obj"></param>
        public static void Update(Supplier obj)
        {
            new SupplierDAO();

            try
            {
                string sql = @"UPDATE supplier SET 
                name=@name, fantasy_name=@fantasy_name,cnpj=@cnpj, emial=@emial, phone_number=@phone_number, telephone_number=@telephone_number,
                state=@state, city=@city, neighborhood=@neighborhood, street=@street, home_number, cep=@cep";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@name", obj.Name);
                cmd.Parameters.AddWithValue("@cnpj", obj.CNPJ);
                cmd.Parameters.AddWithValue("@email", obj.Email);
                cmd.Parameters.AddWithValue("@phone_number", obj.PhoneNumber);
                cmd.Parameters.AddWithValue("@telefone_number", obj.TelephoneNumber);
                cmd.Parameters.AddWithValue("@state", obj.State);
                cmd.Parameters.AddWithValue("@city", obj.City);
                cmd.Parameters.AddWithValue("@neighborhood", obj.Neighbordhood);
                cmd.Parameters.AddWithValue("@street", obj.Street);
                cmd.Parameters.AddWithValue("@home_number", obj.HomeNumber);
                cmd.Parameters.AddWithValue("@cep", obj.CEP);
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}");
                throw;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o fornecedor do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public static void Delete(int cod)
        {
            try
            {
                string sql = "DELETE supplier WHERE cod=@cod";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Close();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO", "O Fornecedor foi deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                throw;
            }
            finally {_connection.Close(); } 
        }
        #endregion

        #region Consult
        /// <summary>
        /// Consulta os fronecedores no banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult()
        {
            try
            {
                new SupplierDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM supplier";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter();
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
    }
}
