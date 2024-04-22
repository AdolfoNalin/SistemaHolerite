using MySql.Data.MySqlClient;
using SistemaHolerite.Connection;
using SistemaHolerite.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.DAO
{
    public class ServicoDAO
    {
        static private MySqlConnection _connection;
        public ServicoDAO() 
        {
            _connection = new ConnectionFactory().GetConnection();
        }

        #region Insert
        public static void Insert(Servico obj)
        {
            try
            {
                new ServicoDAO();

                string sql = @"insert into tb_servico (dr,dc, resp,st,pv,pp,obs)
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

                MessageBox.Show($"O serviço {obj.DR} foi salvo com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
            finally { _connection.Close(); }
        }
        #endregion

        #region UpDate
        public static void UpDate(Servico obj)
        {
            try
            {
                new ServicoDAO();
                string sql = "update tb_servico (dr=@dr, dc=@dc, resp=@resp, st=@st, pv=@pv, pp=@pp, obs=@obs)";

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
                MessageBox.Show($"O serviço {obj.DR} foi Atualizado com sucesso");
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
                new ServicoDAO();
                string sql = "delete tb_servico id where @id";

                MySqlCommand cmd = new MySqlCommand(sql, _connection);
                cmd.Parameters.AddWithValue("@id", id);

                _connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Serviço foi deletado com sucesso!");
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
                new ServicoDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_servico";

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
                new ServicoDAO();
                dr = "%" + dr + "%";

                DataTable dt = new DataTable();
                string sql = "select * from tb_servico dr like @dr";

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

        #region BuscarId
        public static Servico Buscar(int id)
        {
            try
            {
                new ServicoDAO();
                Servico obj = new Servico();

                string sql = "select * from tb_prodoctor id where @id";

                MySqlCommand cmd = new MySqlCommand( sql, _connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                if(dr.Read())
                {
                    obj.DR = dr.GetString("descricao_completa");
                    obj.PV = dr.GetFloat("preco_vista");
                    obj.PP = dr.GetFloat("preco_prazo)");
                }

                return obj;
            }catch(MySqlException ex)
            {
                MessageBox.Show($"Aconteceu um erro com a conexão!");
                return null;
            }catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu erro com o caminho {ex.Message} com o caminho para {ex.StackTrace}");
                return null;
            }
            finally
            {
                _connection.Close();
            }
        }
        #endregion

        #region Buscar
        public static DataTable Buscar(string dr)
        {
            try
            {
                new ServicoDAO();
                DataTable dt = new DataTable();

                string sql = "select * from tb_servico dr where @dr";

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