using Microsoft.VisualBasic.Logging;
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

namespace SistemaHolerite.VIEW
{
    public partial class frmCadastrarOrcamento : Form
    {
        public frmCadastrarOrcamento()
        {
            InitializeComponent();
        }

        #region Load
        private void frmCadastrarOrcamento_Load(object sender, EventArgs e)
        {
            mtbData.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region AddPro
        private void button2_Click(object sender, EventArgs e)
        {
            if (rbPrazo.Checked == false && rbVista.Checked == false)
            {
                MessageBox.Show("Escolha a forma de pagamento!", "ATENÇÃO");
            }
            else
            {
                int id = int.Parse(txtId.Text);
                string dr = txtDR.Text;
                float vp = float.Parse(txtVP.Text);
                float vv = float.Parse(txtVV.Text);
                int qtd = int.Parse(txtQtd.Text);
                float subtotal = 0;

                if(id == 0)
                {
                    if (rbVista.Checked)
                    {
                        subtotal = vv * qtd;
                    }
                    else if (rbPrazo.Checked)
                    {
                        subtotal = vp * qtd;
                    }

                    dgOrcamento.Rows.Add(id, dr, vp, vv, qtd, subtotal);
                }
                
            }
        }
        #endregion

        #region btnPesDR
        private void btnPesDR_Click(object sender, EventArgs e)
        {
            frmConsultarProduto tela = new frmConsultarProduto();
            tela.ShowDialog();
        }
        #endregion

        #region BuscaId
        private void txtIdPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                int id = int.Parse(txtId.Text);
                Severce obj = SeverceDAO.Buscar(id);

                txtDR.Text = obj.BriefDescription;
                txtVV.Text = obj.CashPrice.ToString();
                txtVP.Text = obj.TermPrice.ToString();
            }
        }
        #endregion
    }
}
