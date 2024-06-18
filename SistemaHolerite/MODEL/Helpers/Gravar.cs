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

        #region Insert
        public static void InsertBudget(int codClient, int codEmp, 
            string payment, float subtotal, float total, DataGridView dg)
        {
            try
            {
                Budget obj = new Budget()
                {
                    CodClient = codClient,
                    CodEmp = codEmp,
                    Payment = payment,
                    Subtotal = subtotal,
                    Total = total
                };

                BudgetDAO.Indo(obj);

                int cod = BudgetDAO.EndOrcamento();

                if (cod != 0)
                {
                    foreach (DataGridViewRow OR in dg.Rows)
                    {
                        ItemBudget io = new ItemBudget()
                        {
                            CodBudget = cod,
                            CodProduct = int.Parse(OR.Cells[1].Value.ToString()),
                            Amount = int.Parse(OR.Cells[2].Value.ToString()),
                            Price = float.Parse(OR.Cells[3].Value.ToString())
                        };

                        ItemBudgetDAO.Insert(io);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }
        }
        #endregion

        #region InsertHolerite
        public static void InsertHolerite(int idCliente, int idFuncionario,
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
        #endregion
    }
}
