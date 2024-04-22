using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
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
    public class ProdutoDAO
    {
        private static MySqlConnection _connection;
        public ProdutoDAO()
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Isert indo
        public static void Insert(Produto obj)
        {
            try
            {
                new ProdutoDAO();

                string sql = @"insert into tb_productor (dr,dc, resp,st,pv,pp,obs)
                    value (@dr,@dc,@resp,@st,@pv,@pp,@obs)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@dr", obj.DR);
                cmd.Parameters.AddWithValue("@dc", obj.DC);
                cmd.Parameters.AddWithValue("@resp", obj.Responsavel);
                cmd.Parameters.AddWithValue("@st", obj.Status);
                cmd.Parameters.AddWithValue("@pv", obj.PV);
                cmd.Parameters.AddWithValue("@pp", obj.PP);
                cmd.Parameters.AddWithValue("@obj", obj.Obs);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show($"O produto {obj.DR} foi salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Update
        public static void UpDate(Produto obj)
        {
            try
            {
                new ProdutoDAO();
                string sql = @"update tb_productor (dr=@dr, dc=@dc, resp=@resp,
                    st=@st, pv=@pv, pp=@pp, obs=@obs)";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@dr", obj.DR);
                cmd.Parameters.AddWithValue("@dc", obj.DC);
                cmd.Parameters.AddWithValue("@resp", obj.Responsavel);
                cmd.Parameters.AddWithValue("@st", obj.Status);
                cmd.Parameters.AddWithValue("@pv", obj.PV);
                cmd.Parameters.AddWithValue("@pp", obj.PP);
                cmd.Parameters.AddWithValue("@obs", obj.Obs);

                _connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"O produto {obj.DR} foi Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region Delete
        public static void Delete(int id)
        {
            try
            {
                new ProdutoDAO();
                string sql = "delete tb_prodoctor id where @id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto foi deletado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }


        }
        #endregion

        #region Consult
        public static DataTable Consult()
        {
            try
            {
                new ProdutoDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_prodoctor";

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(dt);

                _connection.Open();
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

        #region ConsultName
        public static DataTable Consult(string dr)
        {
            try
            {
                new ProdutoDAO();
                dr = "%" + dr + "%";

                DataTable dt = new DataTable();
                string sql = "select * from tb_prodoctor dr like @dr";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@dr", dr);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                _connection.Open();
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
        public static DataTable Buscar(string dr)
        {
            try
            {
                new ProdutoDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_prodoctor dr where @dr";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@dr", dr);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                _connection.Open();
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
