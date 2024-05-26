using SistemaHolerite.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHolerite.MODEL.Helpers
{
    public class Gravar
    {
        
        public static void GravarHolerite()
        {

        }

        public static void GravarOrcamento(int idCliente, int idFuncionario, 
            int dp, float subtotal, float total, DataGridView dg)
        {
            try
            {
                Orcamento obj = new Orcamento()
                {
                    IdCliente = idCliente,
                    IdFun = idFuncionario,
                    DP = dp,
                    Subtotal = subtotal,
                    Total = total
                };

                OrcamentoDAO.Indo(obj);

                int id = OrcamentoDAO.EndOrcamento();

                if (id != 0)
                {
                    foreach (DataGridViewRow OR in dg.Rows)
                    {
                        ItemOrcamento io = new ItemOrcamento()
                        {
                            IdOrcamento = id,
                            IdProduto = int.Parse(OR.Cells[1].Value.ToString()),
                            Qtd = int.Parse(OR.Cells[2].Value.ToString()),
                            Price = float.Parse(OR.Cells[3].Value.ToString())
                        };

                        ItemOrcamentoDAO.Insert(io);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }

        public static void GravarHolerite(int idCliente, int idFuncionario,
            int dp, float subtotal, float total, DataGridView dg)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um errodo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
    }
}
