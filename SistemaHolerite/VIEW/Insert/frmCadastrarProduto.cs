using SistemaHolerite.DAO;
using SistemaHolerite.MODEL;
using SistemaHolerite.MODEL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                if (txtId.Text == String.Empty)
                {
                    for (int i = 0; i < dgCP.Rows.Count; i++)
                    {
                        Produto produto = new Produto()
                        {
                            DR = dgCP.CurrentRow.Cells[0].Value.ToString(),
                            DC = dgCP.CurrentRow.Cells[1].Value.ToString(),
                            IdRes = int.Parse(dgCP.CurrentRow.Cells[0].Value.ToString()),
                            PV = float.Parse(txtPV.Text),
                            PP = float.Parse(txtPP.Text),
                            Obs = txtObs.Text
                        };

                        ProdutoDAO.Insert(produto);
                    }

                    DialogResult resp = Dialogo.DialogYesNo("ATENÇÃO", "Deseja cadastrar outro produto?");

                    if (resp == DialogResult.Yes)
                    {
                        txtId.Text = string.Empty;
                        txtDR.Text = string.Empty;
                        txtDC.Text = string.Empty;
                        txtPV.Text = string.Empty;
                        txtPP.Text = string.Empty;
                        cbFor.Text = string.Empty;
                        txtObs.Text = string.Empty;
                    }
                    else
                    {
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} como o caminho para {ex.StackTrace}");
            }

        }
        #endregion

        #region Load
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            // cbFor.DataSource = FornecedorDAO.Consult();
            cbFor.ValueMember = "id";
            cbFor.DisplayMember = "name";

            dgCP.Columns.Add("dr","Descrição Resumida");
            dgCP.Columns.Add("dc", "Descrição Completa");
            dgCP.Columns.Add("pv", "Preço á Vista");
            dgCP.Columns.Add("pp", "Preço á Prazo");
            dgCP.Columns.Add("qtd", "Quantidade");
            dgCP.Columns.Add("obs", "Observação");
        }
        #endregion

        #region AddDG
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPrazo.Checked || rbVista.Checked)
                {
                    Produto obj = new Produto();

                    obj.DR = txtDR.Text;
                    obj.DC = txtDC.Text;
                    obj.IdRes = 0;//int.Parse(cbFor.ValueMember.ToString());
                    obj.PV = float.Parse(txtPV.Text);
                    obj.PP = float.Parse(txtPP.Text);
                    obj.Qtd = int.Parse(txtQtd.Text);
                    obj.Obs = txtObs.Text;

                    dgCP.Rows.Add(obj.DC,obj.DR, obj.PV, obj.PP, obj.Qtd, obj.Obs);

                    txtId.Text = string.Empty;
                    txtDC.Text = string.Empty;
                    txtDR.Text = string.Empty;
                    txtPP.Text = string.Empty;
                    txtPV.Text = string.Empty;
                    txtQtd.Text = string.Empty;
                    txtObs.Text = string.Empty;
                }
                else
                {
                    DialogResult res = Dialogo.DialogYesNo("Verificação", "Virifique a forma de pagamento! \nDeseja que a forma de pagamento seja no Á VISTA?");

                    if (res == DialogResult.Yes)
                    {
                        rbVista.Checked = true;
                    }
                    else
                    {
                        rbPrazo.Checked = true;
                    }
                }
            }
            catch (FormatException ex)
            {
                Dialogo.Message("ATENÇÃO", "Por favor, preencha os campos com os valores corretos!");
            }
            catch (NullReferenceException ex)
            {
                Dialogo.Message("ATENÇÃO", "Verifique se todos os campos estão preenchidos!");
            }
        }
        #endregion

        #region btnRemover
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(dgCP.DataSource != null)
            {
                int index = dgCP.CurrentRow.Index;
                dgCP.Rows.RemoveAt(index);
            }
            else
            {
                Dialogo.Message("ATENÇÃO", "A tabela não possui nenhum produto!");
            }
        }
        #endregion
    }
}
