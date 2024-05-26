using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL.Helpers
{
    public class Cep
    {
        private string _cep;

        public Cep(string cep)
        {
           _cep = cep;
        }

        public List<string> Buscar(string _cep) 
        { 
            try
            {
                List<string> endereco = new List<string>();

                string xmlUrl = $"https://viacep.com.br/ws/{_cep}/xml";
                DataSet ds = new DataSet();
                ds.ReadXml(xmlUrl);

                //endereco.Add(ds.Tables[0].Rows[0]["logradouro"].ToString());
                //endereco.Add(ds.Tables[0].Rows[0]["bairro"].ToString());
                //endereco.Add(ds.Tables[0].Rows[0]["localidade"].ToString());
                //endereco.Add(ds.Tables[0].Rows[0]["complemento"].ToString());
                //endereco.Add(ds.Tables[0].Rows[0]["uf"].ToString());

                MessageBox.Show(ds.Tables[0].Rows[0]["uf"].ToString());
                return endereco;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho {ex.StackTrace}");
            }
            finally
            {
                throw null;
            }
        }
    }
}
