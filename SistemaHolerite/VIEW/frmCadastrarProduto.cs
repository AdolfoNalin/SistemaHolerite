using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
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
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        #region Salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto obj = new Produto()
                {
                    DR = txtDR.Text,
                    DC = txtDC.Text,
                    Responsavel = cbRes.Text,
                    Status = cbStatus.Text,
                    PV = float.Parse(txtPV.Text),
                    PP = float.Parse(txtPP.Text),
                    Obs = txtObs.Text
                };

                DialogResult resp = Dialogo.DialogYesNo("ATENÇÃO", "Deseja cadastrar outro produto?");

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

            }catch(Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho para {ex.StackTrace}");
            }

        }
        #endregion
    }
}
