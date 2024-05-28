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
    public partial class frmConsultarCliente : Form
    {
        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultarCliente_Load(object sender, EventArgs e)
        {
            dgCliente.DataSource = ClienteDAO.Consult();
        }
        #endregion

        #region PesquisaKeyPress
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = txtPesquisar.Text;
            dgCliente.DataSource = ClienteDAO.Consult(name);
        }
        #endregion

        #region Buscar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string name = txtPesquisar.Text;
            dgCliente.DataSource = ClienteDAO.Buscar(name);
        }
        #endregion
    }
}
