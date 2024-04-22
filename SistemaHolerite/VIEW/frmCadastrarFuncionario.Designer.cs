namespace SistemaHolerite.VIEW
{
    partial class frmCadastrarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbnSave = new Button();
            btnEdit = new Button();
            btnDelet = new Button();
            btnNovo = new Button();
            lblName = new Label();
            txtName = new TextBox();
            mtbCPF = new MaskedTextBox();
            lblCPF = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblNumPhone = new Label();
            mtbNumPhone = new MaskedTextBox();
            lblCEP = new Label();
            mtbCEP = new MaskedTextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            cbCargo = new ComboBox();
            lblCargo = new Label();
            lblSalario = new Label();
            txtSalario = new TextBox();
            txtCity = new TextBox();
            lblCity = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtLog = new TextBox();
            lblLogradouro = new Label();
            txtHomeNum = new TextBox();
            lblHomeNum = new Label();
            txtComp = new TextBox();
            llbComplemento = new Label();
            pbImg = new PictureBox();
            btnBuscarImg = new Button();
            btnLimpar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            SuspendLayout();
            // 
            // tbnSave
            // 
            tbnSave.Location = new Point(99, 374);
            tbnSave.Name = "tbnSave";
            tbnSave.Size = new Size(113, 47);
            tbnSave.TabIndex = 0;
            tbnSave.Text = "Salvar";
            tbnSave.UseVisualStyleBackColor = true;
            tbnSave.Click += tbnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(266, 374);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 47);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(429, 374);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(113, 47);
            btnDelet.TabIndex = 2;
            btnDelet.Text = "Deletar";
            btnDelet.UseVisualStyleBackColor = true;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(584, 374);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(113, 47);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(119, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Nome:";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 5;
            // 
            // mtbCPF
            // 
            mtbCPF.Location = new Point(418, 46);
            mtbCPF.Mask = "999.999.999-99";
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(78, 23);
            mtbCPF.TabIndex = 6;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(384, 50);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 7;
            lblCPF.Text = "CPF:";
            // 
            // txtId
            // 
            txtId.Location = new Point(65, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(15, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 15);
            lblId.TabIndex = 8;
            lblId.Text = "Código:";
            // 
            // lblNumPhone
            // 
            lblNumPhone.AutoSize = true;
            lblNumPhone.Location = new Point(502, 49);
            lblNumPhone.Name = "lblNumPhone";
            lblNumPhone.Size = new Size(47, 15);
            lblNumPhone.TabIndex = 11;
            lblNumPhone.Text = "Celular:";
            // 
            // mtbNumPhone
            // 
            mtbNumPhone.Location = new Point(549, 46);
            mtbNumPhone.Mask = "(99) 99999-9999";
            mtbNumPhone.Name = "mtbNumPhone";
            mtbNumPhone.Size = new Size(79, 23);
            mtbNumPhone.TabIndex = 10;
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(57, 166);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 15);
            lblCEP.TabIndex = 13;
            lblCEP.Text = "CEP:";
            // 
            // mtbCEP
            // 
            mtbCEP.Location = new Point(91, 162);
            mtbCEP.Mask = "99999-999";
            mtbCEP.Name = "mtbCEP";
            mtbCEP.Size = new Size(55, 23);
            mtbCEP.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(189, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(149, 105);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(453, 101);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(104, 23);
            cbCargo.TabIndex = 16;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(408, 104);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 17;
            lblCargo.Text = "Cargo:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(19, 105);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(45, 15);
            lblSalario.TabIndex = 19;
            lblSalario.Text = "Salario:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(66, 101);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(71, 23);
            txtSalario.TabIndex = 20;
            // 
            // txtCity
            // 
            txtCity.AcceptsReturn = true;
            txtCity.Location = new Point(213, 163);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(208, 23);
            txtCity.TabIndex = 22;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(164, 167);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(47, 15);
            lblCity.TabIndex = 21;
            lblCity.Text = "Cidade:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(480, 162);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(175, 23);
            txtBairro.TabIndex = 24;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(438, 165);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 23;
            lblBairro.Text = "Bairro:";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(132, 215);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(264, 23);
            txtLog.TabIndex = 26;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(63, 218);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 25;
            lblLogradouro.Text = "Logradouro:";
            // 
            // txtHomeNum
            // 
            txtHomeNum.Location = new Point(487, 215);
            txtHomeNum.Name = "txtHomeNum";
            txtHomeNum.Size = new Size(55, 23);
            txtHomeNum.TabIndex = 28;
            // 
            // lblHomeNum
            // 
            lblHomeNum.AutoSize = true;
            lblHomeNum.Location = new Point(439, 218);
            lblHomeNum.Name = "lblHomeNum";
            lblHomeNum.Size = new Size(54, 15);
            lblHomeNum.TabIndex = 27;
            lblHomeNum.Text = "Número:";
            // 
            // txtComp
            // 
            txtComp.Location = new Point(131, 273);
            txtComp.Multiline = true;
            txtComp.Name = "txtComp";
            txtComp.Size = new Size(623, 67);
            txtComp.TabIndex = 30;
            // 
            // llbComplemento
            // 
            llbComplemento.AutoSize = true;
            llbComplemento.Location = new Point(41, 273);
            llbComplemento.Name = "llbComplemento";
            llbComplemento.Size = new Size(87, 15);
            llbComplemento.TabIndex = 29;
            llbComplemento.Text = "Complemento:";
            // 
            // pbImg
            // 
            pbImg.BackColor = Color.FromArgb(128, 255, 255);
            pbImg.Location = new Point(669, 12);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(119, 137);
            pbImg.TabIndex = 31;
            pbImg.TabStop = false;
            // 
            // btnBuscarImg
            // 
            btnBuscarImg.Location = new Point(669, 155);
            btnBuscarImg.Name = "btnBuscarImg";
            btnBuscarImg.Size = new Size(57, 47);
            btnBuscarImg.TabIndex = 32;
            btnBuscarImg.Text = "Buscar";
            btnBuscarImg.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(732, 155);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 47);
            btnLimpar.TabIndex = 33;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(611, 101);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(44, 23);
            txtSenha.TabIndex = 35;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(564, 104);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 34;
            lblSenha.Text = "Senha:";
            // 
            // frmCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscarImg);
            Controls.Add(pbImg);
            Controls.Add(txtComp);
            Controls.Add(llbComplemento);
            Controls.Add(txtHomeNum);
            Controls.Add(lblHomeNum);
            Controls.Add(txtLog);
            Controls.Add(lblLogradouro);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtCity);
            Controls.Add(lblCity);
            Controls.Add(txtSalario);
            Controls.Add(lblSalario);
            Controls.Add(lblCargo);
            Controls.Add(cbCargo);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblCEP);
            Controls.Add(mtbCEP);
            Controls.Add(lblNumPhone);
            Controls.Add(mtbNumPhone);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(lblCPF);
            Controls.Add(mtbCPF);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnNovo);
            Controls.Add(btnDelet);
            Controls.Add(btnEdit);
            Controls.Add(tbnSave);
            Name = "frmCadastrarFuncionario";
            Text = "Cadastrar Funcionário";
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tbnSave;
        private Button btnEdit;
        private Button btnDelet;
        private Button btnNovo;
        private Label lblName;
        private TextBox txtName;
        private MaskedTextBox mtbCPF;
        private Label lblCPF;
        private TextBox txtId;
        private Label lblId;
        private Label lblNumPhone;
        private MaskedTextBox mtbNumPhone;
        private Label lblCEP;
        private MaskedTextBox mtbCEP;
        private TextBox txtEmail;
        private Label lblEmail;
        private ComboBox cbCargo;
        private Label lblCargo;
        private Label lblSalario;
        private TextBox txtSalario;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtLog;
        private Label lblLogradouro;
        private TextBox txtHomeNum;
        private Label lblHomeNum;
        private TextBox txtComp;
        private Label llbComplemento;
        private PictureBox pbImg;
        private Button btnBuscarImg;
        private Button btnLimpar;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}