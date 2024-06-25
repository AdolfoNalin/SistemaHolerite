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
using System.Runtime.CompilerServices;
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
        /// <summary>
        /// Botão que salva o produto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == String.Empty)
                {
                    for (int i = 0; i < dgCP.Rows.Count; i++)
                    {
                        Product produto = new Product()
                        {
                            BriefDescription = dgCP.CurrentRow.Cells[0].Value.ToString(),
                            FullDescription = dgCP.CurrentRow.Cells[1].Value.ToString(),
                            CodEmp = int.Parse(dgCP.CurrentRow.Cells[0].Value.ToString()),
                            CashPrice = float.Parse(txtPV.Text),
                            TermPrice = float.Parse(txtPP.Text),
                            Observation = txtObs.Text
                        };

                        ProductDAO.Insert(produto);
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

            dgCP.Columns.Add("dr", "Descrição Resumida");
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
                    Product obj = new Product();

                    obj.BriefDescription = txtDR.Text;
                    obj.FullDescription = txtDC.Text;
                    obj.CodEmp = 0;//int.Parse(cbFor.ValueMember.ToString());
                    obj.CashPrice = float.Parse(txtPV.Text);
                    obj.TermPrice = float.Parse(txtPP.Text);
                    obj.Amount = int.Parse(txtQtd.Text);
                    obj.Observation = txtObs.Text;

                    dgCP.Rows.Add(obj.BriefDescription, obj.CashPrice, obj.TermPrice, obj.Amount, obj.Observation);

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
            if (dgCP.Rows.Count > 0)
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

        #region btnDelete
        private void btnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDAO.Delete(int.Parse(txtId.Text));
            }
            catch (Exception ex)
            {
                {
                    Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o cominho para {ex.StackTrace}");
                }

            }
        }
        #endregion

        #region
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                new Cleared().limpar(this);
            }catch (Exception ex)
            {
                Dialogo.Message("ATENÇÃO", $"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion
    }
}
