namespace SistemaHolerite.VIEW
{
    partial class frmCadastrarProduto
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
            lblResponsavel = new Label();
            cbRes = new ComboBox();
            txtId = new TextBox();
            lblId = new Label();
            txtObs = new TextBox();
            llbComplemento = new Label();
            txtPV = new TextBox();
            lblPV = new Label();
            txtPP = new TextBox();
            lblPP = new Label();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            txtDC = new TextBox();
            lblDC = new Label();
            txtDR = new TextBox();
            lblDR = new Label();
            btnNew = new Button();
            btnDelet = new Button();
            btnEdit = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(467, 129);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(75, 15);
            lblResponsavel.TabIndex = 92;
            lblResponsavel.Text = "Responsável:";
            // 
            // cbRes
            // 
            cbRes.FormattingEnabled = true;
            cbRes.Location = new Point(543, 126);
            cbRes.Name = "cbRes";
            cbRes.Size = new Size(136, 23);
            cbRes.TabIndex = 91;
            // 
            // txtId
            // 
            txtId.Location = new Point(153, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 90;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(102, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 15);
            lblId.TabIndex = 89;
            lblId.Text = "Código:";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(116, 248);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(623, 67);
            txtObs.TabIndex = 88;
            // 
            // llbComplemento
            // 
            llbComplemento.AutoSize = true;
            llbComplemento.Location = new Point(26, 248);
            llbComplemento.Name = "llbComplemento";
            llbComplemento.Size = new Size(87, 15);
            llbComplemento.TabIndex = 87;
            llbComplemento.Text = "Complemento:";
            // 
            // txtPV
            // 
            txtPV.Location = new Point(546, 83);
            txtPV.Name = "txtPV";
            txtPV.Size = new Size(71, 23);
            txtPV.TabIndex = 86;
            // 
            // lblPV
            // 
            lblPV.AutoSize = true;
            lblPV.Location = new Point(468, 86);
            lblPV.Name = "lblPV";
            lblPV.Size = new Size(76, 15);
            lblPV.TabIndex = 85;
            lblPV.Text = "Preço á vista:";
            // 
            // txtPP
            // 
            txtPP.Location = new Point(703, 83);
            txtPP.Name = "txtPP";
            txtPP.Size = new Size(71, 23);
            txtPP.TabIndex = 84;
            // 
            // lblPP
            // 
            lblPP.AutoSize = true;
            lblPP.Location = new Point(620, 87);
            lblPP.Name = "lblPP";
            lblPP.Size = new Size(81, 15);
            lblPP.TabIndex = 83;
            lblPP.Text = "Preço á Prazo:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(500, 162);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 82;
            lblStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Acabamento", "Reforma", "Alicerce", "Levantamento", "Nenhuma das Alternativas" });
            cbStatus.Location = new Point(543, 159);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(136, 23);
            cbStatus.TabIndex = 81;
            // 
            // txtDC
            // 
            txtDC.Location = new Point(153, 123);
            txtDC.Multiline = true;
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(289, 56);
            txtDC.TabIndex = 80;
            // 
            // lblDC
            // 
            lblDC.AutoSize = true;
            lblDC.Location = new Point(35, 126);
            lblDC.Name = "lblDC";
            lblDC.Size = new Size(119, 15);
            lblDC.TabIndex = 79;
            lblDC.Text = "Descreção Completa:";
            // 
            // txtDR
            // 
            txtDR.Location = new Point(153, 83);
            txtDR.Name = "txtDR";
            txtDR.Size = new Size(289, 23);
            txtDR.TabIndex = 78;
            // 
            // lblDR
            // 
            lblDR.AutoSize = true;
            lblDR.Location = new Point(35, 86);
            lblDR.Name = "lblDR";
            lblDR.Size = new Size(119, 15);
            lblDR.TabIndex = 77;
            lblDR.Text = "Descreção Resumida:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(569, 349);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(113, 47);
            btnNew.TabIndex = 76;
            btnNew.Text = "Novo";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(414, 349);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(113, 47);
            btnDelet.TabIndex = 75;
            btnDelet.Text = "Deletar";
            btnDelet.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(251, 349);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 47);
            btnEdit.TabIndex = 74;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(84, 349);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(113, 47);
            btnSalvar.TabIndex = 73;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResponsavel);
            Controls.Add(cbRes);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtObs);
            Controls.Add(llbComplemento);
            Controls.Add(txtPV);
            Controls.Add(lblPV);
            Controls.Add(txtPP);
            Controls.Add(lblPP);
            Controls.Add(lblStatus);
            Controls.Add(cbStatus);
            Controls.Add(txtDC);
            Controls.Add(lblDC);
            Controls.Add(txtDR);
            Controls.Add(lblDR);
            Controls.Add(btnNew);
            Controls.Add(btnDelet);
            Controls.Add(btnEdit);
            Controls.Add(btnSalvar);
            Name = "frmCadastrarProduto";
            Text = "Cadastrar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResponsavel;
        private ComboBox cbRes;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtObs;
        private Label llbComplemento;
        private TextBox txtPV;
        private Label lblPV;
        private TextBox txtPP;
        private Label lblPP;
        private Label lblStatus;
        private ComboBox cbStatus;
        private TextBox txtDC;
        private Label lblDC;
        private TextBox txtDR;
        private Label lblDR;
        private Button btnNew;
        private Button btnDelet;
        private Button btnEdit;
        private Button btnSalvar;
    }
}