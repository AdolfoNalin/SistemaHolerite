namespace SistemaHolerite.VIEW
{
    partial class frmCadastrarCliente
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
            btnLimpar = new Button();
            btnBuscarImg = new Button();
            pbImg = new PictureBox();
            txtComp = new TextBox();
            llbComplemento = new Label();
            txtHomeNum = new TextBox();
            lblHomeNum = new Label();
            txtLog = new TextBox();
            lblLogradouro = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblCEP = new Label();
            mtbCEP = new MaskedTextBox();
            lblNumPhone = new Label();
            mtbNumPhone = new MaskedTextBox();
            txtId = new TextBox();
            lblId = new Label();
            lblCPF = new Label();
            mtbCPF = new MaskedTextBox();
            txtName = new TextBox();
            lblName = new Label();
            btnNovo = new Button();
            btnDelet = new Button();
            btnEdit = new Button();
            tbnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(718, 164);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(56, 47);
            btnLimpar.TabIndex = 66;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarImg
            // 
            btnBuscarImg.Location = new Point(655, 164);
            btnBuscarImg.Name = "btnBuscarImg";
            btnBuscarImg.Size = new Size(57, 47);
            btnBuscarImg.TabIndex = 65;
            btnBuscarImg.Text = "Buscar";
            btnBuscarImg.UseVisualStyleBackColor = true;
            // 
            // pbImg
            // 
            pbImg.BackColor = Color.FromArgb(128, 255, 255);
            pbImg.Location = new Point(655, 21);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(119, 137);
            pbImg.TabIndex = 64;
            pbImg.TabStop = false;
            // 
            // txtComp
            // 
            txtComp.Location = new Point(117, 282);
            txtComp.Multiline = true;
            txtComp.Name = "txtComp";
            txtComp.Size = new Size(623, 67);
            txtComp.TabIndex = 63;
            // 
            // llbComplemento
            // 
            llbComplemento.AutoSize = true;
            llbComplemento.Location = new Point(27, 282);
            llbComplemento.Name = "llbComplemento";
            llbComplemento.Size = new Size(87, 15);
            llbComplemento.TabIndex = 62;
            llbComplemento.Text = "Complemento:";
            // 
            // txtHomeNum
            // 
            txtHomeNum.Location = new Point(117, 212);
            txtHomeNum.Name = "txtHomeNum";
            txtHomeNum.Size = new Size(55, 23);
            txtHomeNum.TabIndex = 61;
            // 
            // lblHomeNum
            // 
            lblHomeNum.AutoSize = true;
            lblHomeNum.Location = new Point(69, 215);
            lblHomeNum.Name = "lblHomeNum";
            lblHomeNum.Size = new Size(54, 15);
            lblHomeNum.TabIndex = 60;
            lblHomeNum.Text = "Número:";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(374, 164);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(264, 23);
            txtLog.TabIndex = 59;
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(305, 167);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 58;
            lblLogradouro.Text = "Logradouro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(473, 106);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(175, 23);
            txtBairro.TabIndex = 57;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(431, 109);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 56;
            lblBairro.Text = "Bairro:";
            // 
            // txtCity
            // 
            txtCity.AcceptsReturn = true;
            txtCity.Location = new Point(86, 164);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(208, 23);
            txtCity.TabIndex = 55;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(37, 168);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(47, 15);
            lblCity.TabIndex = 54;
            lblCity.Text = "Cidade:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(86, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(208, 23);
            txtEmail.TabIndex = 49;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 109);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 48;
            lblEmail.Text = "Email:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(323, 110);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 15);
            lblCEP.TabIndex = 47;
            lblCEP.Text = "CEP:";
            // 
            // mtbCEP
            // 
            mtbCEP.Location = new Point(354, 106);
            mtbCEP.Mask = "99999-999";
            mtbCEP.Name = "mtbCEP";
            mtbCEP.Size = new Size(59, 23);
            mtbCEP.TabIndex = 46;
            mtbCEP.KeyPress += mtbCEP_KeyPress;
            // 
            // lblNumPhone
            // 
            lblNumPhone.AutoSize = true;
            lblNumPhone.Location = new Point(523, 57);
            lblNumPhone.Name = "lblNumPhone";
            lblNumPhone.Size = new Size(47, 15);
            lblNumPhone.TabIndex = 45;
            lblNumPhone.Text = "Celular:";
            // 
            // mtbNumPhone
            // 
            mtbNumPhone.Location = new Point(570, 54);
            mtbNumPhone.Mask = "(99) 99999-9999";
            mtbNumPhone.Name = "mtbNumPhone";
            mtbNumPhone.Size = new Size(79, 23);
            mtbNumPhone.TabIndex = 44;
            // 
            // txtId
            // 
            txtId.Location = new Point(86, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 43;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(36, 57);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 15);
            lblId.TabIndex = 42;
            lblId.Text = "Código:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(405, 58);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 41;
            lblCPF.Text = "CPF:";
            // 
            // mtbCPF
            // 
            mtbCPF.Location = new Point(439, 54);
            mtbCPF.Mask = "999.999.999-99";
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(78, 23);
            mtbCPF.TabIndex = 40;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 39;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(140, 57);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 38;
            lblName.Text = "Nome:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(570, 383);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(113, 47);
            btnNovo.TabIndex = 37;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(415, 383);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(113, 47);
            btnDelet.TabIndex = 36;
            btnDelet.Text = "Deletar";
            btnDelet.UseVisualStyleBackColor = true;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(252, 383);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 47);
            btnEdit.TabIndex = 35;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // tbnSave
            // 
            tbnSave.Location = new Point(85, 383);
            tbnSave.Name = "tbnSave";
            tbnSave.Size = new Size(113, 47);
            tbnSave.TabIndex = 34;
            tbnSave.Text = "Salvar";
            tbnSave.UseVisualStyleBackColor = true;
            tbnSave.Click += tbnSave_Click;
            // 
            // frmCadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmCadastrarCliente";
            Text = "Cadastrar Cliente";
            Load += frmCadastrarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnBuscarImg;
        private PictureBox pbImg;
        private TextBox txtComp;
        private Label llbComplemento;
        private TextBox txtHomeNum;
        private Label lblHomeNum;
        private TextBox txtLog;
        private Label lblLogradouro;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtCity;
        private Label lblCity;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblCEP;
        private MaskedTextBox mtbCEP;
        private Label lblNumPhone;
        private MaskedTextBox mtbNumPhone;
        private TextBox txtId;
        private Label lblId;
        private Label lblCPF;
        private MaskedTextBox mtbCPF;
        private TextBox txtName;
        private Label lblName;
        private Button btnNovo;
        private Button btnDelet;
        private Button btnEdit;
        private Button tbnSave;
    }
}