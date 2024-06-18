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
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
        }

        #region Load 
        private void frmConsultarProduto_Load(object sender, EventArgs e)
        {
            dgProduto.DataSource = ProductDAO.Consult();
        }
        #endregion

        #region PesquisarkeyPress
        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string name = txtPesquisar.Text;

            dgProduto.DataSource = ProductDAO.Consult(name);

        }
        #endregion

        #region btnPesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string name = txtPesquisar.Text;

            dgProduto.DataSource = ProductDAO.Buscar(name);
        }
        #endregion
    }
}
