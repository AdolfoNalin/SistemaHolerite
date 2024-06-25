using SistemaHolerite.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHolerite.VIEW
{
    public partial class frmConsultarOrcamento : Form
    {
        public frmConsultarOrcamento()
        {
            InitializeComponent();
        }

        #region Load
        /// <summary>
        /// Start of the load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsultarOrcamento_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
            dgOrcamento.DataSource = BudgetDAO.Consult();
        }
        #endregion

        #region SearchKeypPress
        /// <summary>
        /// Pesquisa de letras continuas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = "%" + txtPesquisar.Text + "%";

            if (!string.IsNullOrEmpty(name))
            {
                dgOrcamento.DataSource = BudgetDAO.Consult(name);
            }
            else
            {
                MessageBox.Show($"Por favor, preencha o campo Pesquisar com o nome do cliente!");
            }
        }
        #endregion

        #region btnPesquisar
        /// <summary>
        /// Busca por nome BTN pesquisar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtPesquisar.Text;
                if (!string.IsNullOrEmpty(name))
                {
                    dgOrcamento.DataSource = BudgetDAO.SearchName(name);
                }
                else
                {
                    MessageBox.Show($"Por favor, preencha o campo Pesquisar com o nome do cliente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex} com o caminho {ex.StackTrace}");
            }   
        }
        #endregion
    }
}
