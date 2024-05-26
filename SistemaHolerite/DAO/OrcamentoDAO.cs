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
    public class OrcamentoDAO
    {
        private static MySqlConnection _connection;

        public OrcamentoDAO()
        {
            _connection = new ConnectionFactory().GetConnection();    
        }

        #region insert
        public static void Indo(Orcamento obj)
        {
            try
            {
                new OrcamentoDAO();
                string sql = @"insert into tb_orcamento (id_cliente, id_fun, dp, subtotal, total
            value (@id_client, @id_fun, @dp, @subtotal, @total";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id_client", obj.IdCliente);
                cmd.Parameters.AddWithValue("@id_fun", obj.IdFun);
                cmd.Parameters.AddWithValue("@dp", obj.DP);
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
        public static void UpDate(Orcamento obj)
        {
            try
            {
                new OrcamentoDAO();
                string sql = "update tb_orcamento (id_cliente=@id_cliente, id_fun=@id_fun, dp=@dp, subtotal=@subtotal, total=@total)";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                cmd.Parameters.AddWithValue("@id_cliente", obj.IdCliente);
                cmd.Parameters.AddWithValue("@id_fun", obj.IdFun);
                cmd.Parameters.AddWithValue("@dp", obj.DP);
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
        public static void Delete(int id)
        {
            try
            {
                new OrcamentoDAO();
                string sql = "delete tb_orcamento id where @id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

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
        public static DataTable Consult()
        {
            try
            {
                new OrcamentoDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_client";

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
        public static DataTable Consult(string name)
        {
            try
            {
                new OrcamentoDAO();
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
                MessageBox.Show($"Aconteceu ume erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
                return null;
            }
            finally {_connection.Close(); }
        }
        #endregion

        #region Buscar
        public static DataTable Buscar(string name)
        {
            try
            {
                new OrcamentoDAO();
                name = "%" + name + "%";

                DataTable dt = new DataTable();

                string sql = "select * form tb_orcamento name like @name";

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

        #region UltimoOrcamento
        public static int EndOrcamento()
        {
            int id = 0;
            try
            {
                string sql = "Select max(id) id from tb_orcamento";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    id = Convert.ToInt32("id");
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
