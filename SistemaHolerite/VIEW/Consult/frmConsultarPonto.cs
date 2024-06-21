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

namespace SistemaHolerite.VIEW.Consult
{
    public partial class frmConsultarPonto : Form
    {
        public frmConsultarPonto()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultarHolerite_Load(object sender, EventArgs e)
        {
            dgFuncionario.DataSource = EmployeeDAO.Consultar();
        }
        #endregion

        #region btnPNome
        private void btnPNome_Click(object sender, EventArgs e)
        {
            EmployeeDAO.Consultar(txtNome.Text);
        }
        #endregion

        #region btnPData
        private void btnPesquisarM_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
