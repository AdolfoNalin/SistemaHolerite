using SistemaHolerite.DAO;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHolerite.VIEW
{
    public partial class frmCadastrarServico : Form
    {
        public frmCadastrarServico()
        {
            InitializeComponent();
        }

        #region Load
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            if (txtId.Text != String.Empty)
            {
                cbRes.DataSource = EmployeeDAO.Consultar();
                cbRes.ValueMember = "id";
                cbRes.DisplayMember = "name";
            }
        }
        #endregion

        #region Salve
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Severce ser = new Severce()
            {
                DR = txtDR.Text,
                DC = txtDC.Text,
                IdRes = cbRes.TabIndex,
                PV = float.Parse(txtPV.Text),
                PP = float.Parse(txtPP.Text),
                Obs = txtObs.Text
            };

            SeverceDAO.Insert(ser);

            DialogResult resp = Dialogo.DialogYesNo("ATENÇÃO", "Deseja cadastrar outro Produto?");

            if (resp == DialogResult.Yes)
            {
                txtId.Text = string.Empty;
                txtDR.Text = string.Empty;
                txtDC.Text = string.Empty;
                txtPV.Text = string.Empty;
                txtPP.Text = string.Empty;
                cbRes.Text = string.Empty;
                cbStatus.Text = string.Empty;
                txtObs.Text = string.Empty;
            }
            else
            {
                this.Hide();
            }
        }
        #endregion

        #region Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Severce ser = new Severce()
            {
                DR = txtDR.Text,
                DC = txtDC.Text,
                IdRes = cbRes.TabIndex,
                PV = float.Parse(txtPV.Text),
                PP = float.Parse(txtPP.Text),
                Obs = txtObs.Text
            };

            SeverceDAO.UpDate(ser);
        }
        #endregion

        #region Delete
        private void btnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);

                SeverceDAO.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }

            System.Windows.Forms.DialogResult resp = MessageBox.Show("Deseja cadastrar outro Produto?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question );

            if( resp == System.Windows.Forms.DialogResult.Yes )
            {
                txtId.Text = string.Empty;
                txtDR.Text = string.Empty;
                txtDC.Text = string.Empty;
                txtPV.Text = string.Empty;
                txtPP.Text = string.Empty;
                cbRes.Text = string.Empty;
                cbStatus.Text = string.Empty;
                txtObs.Text = string.Empty;
            }
            else
            {
                this.Hide();
            }
        }
        #endregion

        #region New
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtDR.Text = string.Empty;
            txtDC.Text = string.Empty;
            txtPV.Text = string.Empty;
            txtPP.Text = string.Empty;
            cbRes.Text = string.Empty;
            cbStatus.Text = string.Empty;
            txtObs.Text = string.Empty;
        }
        #endregion
    }
}
