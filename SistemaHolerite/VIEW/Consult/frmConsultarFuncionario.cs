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
    public partial class frmConsultarFuncionario : Form
    {
        public frmConsultarFuncionario()
        {
            InitializeComponent();
        }

        #region Consulta
        /// <summary>
        /// Consultar do banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            dgFuncionario.DataSource = EmployeeDAO.Consultar(); ;
        }
        #endregion

        #region Consulta nome
        /// <summary>
        /// Consulta por nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = txtPesquisar.Text;

            dgFuncionario.DataSource = EmployeeDAO.Consultar(name);
        }
        #endregion

        #region Buscar
        /// <summary>
        /// Buscar com o click do botão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string name = txtPesquisar.Text;
            dgFuncionario .DataSource = EmployeeDAO.Buscar(name);
        }
        #endregion

    }
}
