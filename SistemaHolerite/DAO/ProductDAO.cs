using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHolerite.MODEL.Helpers;
using System.Security.Cryptography;

namespace SistemaHolerite.DAO
{
    public class ProductDAO
    {
        private static MySqlConnection _connection;
        public ProductDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        /// <summary>
        /// Cadastra o produto no banco de dados
        /// </summary>
        /// <param name="obj">Objeto Produtos</param>
        public static void Insert(Product obj)
        {
            try
            {
                new ProductDAO();

                string sql = @"INSERT INTO product (short_description, full_description, cod_supplier, term_price,spot_price,obs, amount,ca)
                VALUE (@short_description,@full_descrition, @cod_supplier,@term_price,@spot_price,@obs),@amount,@ca";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", obj.BriefDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@cod_supplier", obj.CodSupplier);
                cmd.Parameters.AddWithValue("@spot_price", obj.CashPrice);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@ca", obj.CA);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO",$"O produto {obj.BriefDescription} foi salvo com sucesso");
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Update
        /// <summary>
        /// Atualiza os dados do produto no banco de dados
        /// </summary>
        /// <param name="obj">Objeto produto</param>
        public static void UpDate(Product obj)
        {
            try
            {
                new ProductDAO();
                string sql = @"UPDATE product SET short_description=@short_description, full_description=@full_description, cod_supplier=@cod_supplier,
                spot_price=@spot-price, term_price=@term_price, obs=@obs, amount=@amount, ca=@ca";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", obj.BriefDescription);
                cmd.Parameters.AddWithValue("@full_description", obj.FullDescription);
                cmd.Parameters.AddWithValue("@cod_supplier", obj.CodSupplier);
                cmd.Parameters.AddWithValue("@spot_price", obj.CashPrice);
                cmd.Parameters.AddWithValue("@term_price", obj.TermPrice);
                cmd.Parameters.AddWithValue("@obs", obj.Observation);
                cmd.Parameters.AddWithValue("@amount", obj.Amount);
                cmd.Parameters.AddWithValue("@ca", obj.CA);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O produto {obj.BriefDescription} foi Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deleta o produto do banco de dados
        /// </summary>
        /// <param name="cod"></param>
        public static void Delete(int cod)
        {
            try
            {
                new ProductDAO();
                string sql = "DELETE product WHERE @cod";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@cod", cod);

                _connection.Open();
                cmd.ExecuteNonQuery();

                Dialogo.Message("SUCESSO", "Produto foi deletado com sucesso!");
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
        /// Consulta todos os produtos no banco de dados
        /// </summary>
        /// <returns></returns>
        public static DataTable Consult()
        {
            DataTable dt = new DataTable();
            try
            {
                new ProductDAO();

                string sql = "SELECT * FROM product";


                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                Dialogo.Message("ATRENÇÃO", $"Aconteceu um erro com o caminho {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region ConsultName
        /// <summary>
        /// Consultar o produto pelo nome com de acordo com a digitação
        /// </summary>
        /// <param name="short_description">Descrição resumida</param>
        /// <returns></returns>
        public static DataTable Consult(string short_description)
        {
            try
            {
                new ProductDAO();
                short_description = Dialogo.LikeString(short_description);

                DataTable dt = new DataTable();
                string sql = "SELECT * FROM product short_description like @short_description";

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
                MessageBox.Show($"Aconteceu um erro com o caminho {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Buscar
        /// <summary>
        /// Busco um protudo no banco de dados de acordo com a descrição 
        /// </summary>
        /// <param name="short_description">Descrição resumida</param>
        /// <returns></returns>
        public static DataTable Buscar(string short_description)
        {
            try
            {
                new ProductDAO();
                DataTable dt = new DataTable();

                string sql = "SELECT * FROM product short_description WHERE @short_description";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@short_description", short_description);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                _connection.Open();
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
