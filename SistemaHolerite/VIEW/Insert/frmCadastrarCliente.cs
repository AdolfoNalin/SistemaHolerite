using SistemaHolerite.DAO;
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
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        #region Salvar
        private void tbnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Client obj = new Client()
                {
                    Name = txtName.Text,
                    CPF = mtbCPF.Text,
                    NumPhone = mtbNumPhone.Text,
                    Email = txtEmail.Text,
                    Logradouro = txtLog.Text,
                    HomeNum = int.Parse(txtHomeNum.Text),
                    Bairro = txtBairro.Text,
                    CEP = mtbCEP.Text,
                    City = txtCity.Text,
                    Complemento = txtComp.Text,
                    //Img = pbImg.

                };

                ClienteDAO.Insert(obj);

                DialogResult resp = Dialogo.DialogYesNo("ATENÇÃO", "Deseja cadastrar outro cliente?");

                if (resp == DialogResult.Yes)
                {
                    txtId.Text = string.Empty;
                    txtName.Text = string.Empty;
                    mtbCPF.Text = string.Empty;
                    mtbNumPhone.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    mtbCEP.Text = string.Empty;
                    txtCity.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    txtLog.Text = string.Empty;
                    txtHomeNum.Text = string.Empty;
                    txtComp.Text = string.Empty;
                }
                else
                {

                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region UpDate
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Client obj = new Client()
                {
                    Name = txtName.Text,
                    CPF = mtbCPF.Text,
                    NumPhone = mtbNumPhone.Text,
                    Email = txtEmail.Text,
                    Logradouro = txtLog.Text,
                    HomeNum = int.Parse(txtHomeNum.Text),
                    Bairro = txtBairro.Text,
                    CEP = mtbCEP.Text,
                    City = txtCity.Text,
                    Complemento = txtComp.Text,
                    //Img = pbImg.

                };

                ClienteDAO.UpDate(obj);

                DialogResult resp = Dialogo.DialogYesNo("ATENÇÃO", "Deseja atualizar outro cliente?");

                if (resp == DialogResult.Yes)
                {
                    frmConsultarCliente tela = new frmConsultarCliente();
                    this.Hide();
                    tela.ShowDialog();
                }
                else
                {
                    this.Hide();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Por favor. Certifiquesse que todos os dados estão preenchidos!");
            }
        }
        #endregion

        #region Delete
        private void btnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);

                ClienteDAO.Delete(id);

                DialogResult resp = Dialogo.DialogYesNo("ATENÇÃO", "Deseja Deletar outro Cliente?");

                if (resp == DialogResult.Yes)
                {
                    frmConsultarCliente tela = new frmConsultarCliente();
                    this.Hide();
                    tela.ShowDialog();
                }
                else
                {
                    this.Hide();
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Id não correspondente!");
            }
        }
        #endregion

        #region New
        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            mtbCPF.Text = string.Empty;
            mtbNumPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mtbCEP.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtLog.Text = string.Empty;
            txtHomeNum.Text = string.Empty;
            txtComp.Text = string.Empty;
        }
        #endregion

        #region Load
        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {

        }
        #endregion


        #region BuscarCEP
        private void mtbCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                string cep = mtbCEP.Text;
                Cep c = new Cep(cep);
                List<string> p = c.Buscar(cep);

                for(int i = 0; i < p.Count; i++)
                {
                    MessageBox.Show(p[i]);
                }
            }
        }
        #endregion
    }
}
