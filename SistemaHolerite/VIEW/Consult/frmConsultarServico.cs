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
    public partial class frmConsultarServico : Form
    {
        public frmConsultarServico()
        {
            InitializeComponent();
        }

        #region Load
        private void frmConsultarServico_Load(object sender, EventArgs e)
        {
            dgServico.DataSource = SeverceDAO.Consult();
        }
        #endregion

        #region PesquisaKeyPress
        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = txtPesquisa.Text;

            dgServico.DataSource = SeverceDAO.Consult(name);
        }
        #endregion

        #region btnPesquisar
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dgServico.DataSource = SeverceDAO.Buscar(txtPesquisa.Text);
        }
        #endregion
    }
}
