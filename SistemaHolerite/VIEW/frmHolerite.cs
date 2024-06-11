using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHolerite.VIEW
{
    public partial class frmHolerite : Form
    {
        public frmHolerite()
        {
            InitializeComponent();
        }

        #region Load
        private void frmHolerite_Load(object sender, EventArgs e)
        {
            txtDataRef.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region Click
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            frmConsultarFuncionario tela = new frmConsultarFuncionario();
            tela.ShowDialog();
        }
        #endregion
    }
}
