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
    public partial class frmCadastrarFuncionario : Form
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        #region Salvar
        /// <summary>
        /// Button para salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Employee obj = new Employee()
                {
                    Name = txtName.Text,
                    CPF = mtbCPF.Text,
                    PhoneNumber = mtbNumPhone.Text,
                    Email = txtEmail.Text,
                    Wage = float.Parse(txtSalario.Text),
                    // = cbCargo.Text,
                    Password = txtSenha.Text,
                    Street = txtLog.Text,
                    HomeNumber = int.Parse(txtHomeNum.Text),
                    Neighbordhood = txtBairro.Text,
                    CEP = mtbCEP.Text,
                    City = txtCity.Text,
                    Complement = txtComp.Text,
                    //Img = pbImg.

                };

                EmployeeDAO.Insert(obj);

                System.Windows.Forms.DialogResult resp = MessageBox.Show("Deseja cadastrar outro funcionário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resp == System.Windows.Forms.DialogResult.Yes)
                {
                    txtId.Text = string.Empty;
                    txtName.Text = string.Empty;
                    mtbCPF.Text = string.Empty;
                    mtbNumPhone.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtSalario.Text = string.Empty;
                    //cbCargo.Text = string.Empty;
                    txtSenha.Text = string.Empty;
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
                    frmConsultarFuncionario telaConsu = new frmConsultarFuncionario();
                    telaConsu.dgFuncionario.DataSource = EmployeeDAO.Consultar();
                    telaConsu.ShowDialog();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro do formatação. Certifique que os campos estão com os valores certos!");
            }
        }
        #endregion

        #region Editar
        /// <summary>
        /// Button que Edita o funcionário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Employee obj = new Employee()
                {
                    Name = txtName.Text,
                    CPF = mtbCPF.Text,
                    PhoneNumber = mtbNumPhone.Text,
                    Email = txtEmail.Text,
                    Wage = float.Parse(txtSalario.Text),
                    //Permicoes = ,
                    Street = txtLog.Text,
                    HomeNumber = int.Parse(txtHomeNum.Text),
                    Neighbordhood = txtBairro.Text,
                    CEP = mtbCEP.Text,
                    City = txtCity.Text,
                    Complement = txtComp.Text,
                    //Img = pbImg.

                };

                EmployeeDAO.UpDate(obj);

                System.Windows.Forms.DialogResult resp = MessageBox.Show("Deseja editar outro funcionário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
            }
        }
        #endregion

        #region Delete
        /// <summary>
        /// Button Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelet_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);

                EmployeeDAO.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aconteceu um erro do tipo {ex.Message} com o caminho {ex.StackTrace}");
            }

        }
        #endregion

        #region Limpar
        /// <summary>
        /// Botão de limpar campos
        /// </summary>
        /// <param name="sender"></param>s
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
           txtId.Text = string.Empty;
           txtName.Text = string.Empty;
           mtbCPF.Text = string.Empty;
           mtbNumPhone.Text = string.Empty;
           txtEmail.Text = string.Empty;
           txtSalario.Text = string.Empty;
           //cbCargo.Text = string.Empty;
           txtSenha.Text = string.Empty;
           mtbCEP.Text = string.Empty;
           txtCity.Text = string.Empty;
           txtBairro.Text = string.Empty;
           txtLog.Text = string.Empty;
           txtHomeNum.Text = string.Empty;
           txtComp.Text = string.Empty;
           
        }
        #endregion
    }
}
