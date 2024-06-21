using SistemaHolerite.DAO;
using SistemaHolerite.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHolerite.VIEW.Show
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region btnEntrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string password = txtSenha.Text;
            if (EmployeeDAO.Login(name, password))
            {
                this.Hide();
                frmMenu tela = new frmMenu();
                tela.Show();
            }
        }
        #endregion

        #region btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion
    }
}
