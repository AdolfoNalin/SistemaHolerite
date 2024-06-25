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
            lblFornecedor = new Label();
            cbFor = new ComboBox();
            txtId = new TextBox();
            lblId = new Label();
            txtObs = new TextBox();
            lblObs = new Label();
            txtPV = new TextBox();
            lblPV = new Label();
            txtPP = new TextBox();
            lblPP = new Label();
            txtDC = new TextBox();
            lblDC = new Label();
            txtDR = new TextBox();
            lblDR = new Label();
            btnNew = new Button();
            btnDelet = new Button();
            btnEdit = new Button();
            btnSalvar = new Button();
            dgCP = new DataGridView();
            rbPrazo = new RadioButton();
            rbVista = new RadioButton();
            btnAdd = new Button();
            btnRemover = new Button();
            txtQtd = new TextBox();
            lblQtd = new Label();
            lblCA = new Label();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgCP).BeginInit();
            SuspendLayout();
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(524, 99);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(70, 15);
            lblFornecedor.TabIndex = 92;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // cbFor
            // 
            cbFor.FormattingEnabled = true;
            cbFor.Location = new Point(600, 96);
            cbFor.Name = "cbFor";
            cbFor.Size = new Size(136, 23);
            cbFor.TabIndex = 91;
            // 
            // txtId
            // 
            txtId.Location = new Point(210, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(44, 23);
            txtId.TabIndex = 90;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(159, 28);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 15);
            lblId.TabIndex = 89;
            lblId.Text = "Código:";
            // 
            // txtObs
            // 
            txtObs.Location = new Point(167, 177);
            txtObs.Multiline = true;
            txtObs.Name = "txtObs";
            txtObs.Size = new Size(623, 67);
            txtObs.TabIndex = 88;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Location = new Point(93, 179);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(72, 15);
            lblObs.TabIndex = 87;
            lblObs.Text = "Observação:";
            // 
            // txtPV
            // 
            txtPV.Location = new Point(603, 53);
            txtPV.Name = "txtPV";
            txtPV.Size = new Size(71, 23);
            txtPV.TabIndex = 86;
            // 
            // lblPV
            // 
            lblPV.AutoSize = true;
            lblPV.Location = new Point(525, 56);
            lblPV.Name = "lblPV";
            lblPV.Size = new Size(76, 15);
            lblPV.TabIndex = 85;
            lblPV.Text = "Preço á vista:";
            // 
            // txtPP
            // 
            txtPP.Location = new Point(760, 53);
            txtPP.Name = "txtPP";
            txtPP.Size = new Size(71, 23);
            txtPP.TabIndex = 84;
            // 
            // lblPP
            // 
            lblPP.AutoSize = true;
            lblPP.Location = new Point(677, 57);
            lblPP.Name = "lblPP";
            lblPP.Size = new Size(81, 15);
            lblPP.TabIndex = 83;
            lblPP.Text = "Preço á Prazo:";
            // 
            // txtDC
            // 
            txtDC.Location = new Point(210, 93);
            txtDC.Multiline = true;
            txtDC.Name = "txtDC";
            txtDC.Size = new Size(289, 56);
            txtDC.TabIndex = 80;
            // 
            // lblDC
            // 
            lblDC.AutoSize = true;
            lblDC.Location = new Point(92, 96);
            lblDC.Name = "lblDC";
            lblDC.Size = new Size(119, 15);
            lblDC.TabIndex = 79;
            lblDC.Text = "Descreção Completa:";
            // 
            // txtDR
            // 
            txtDR.Location = new Point(210, 53);
            txtDR.Name = "txtDR";
            txtDR.Size = new Size(289, 23);
            txtDR.TabIndex = 78;
            // 
            // lblDR
            // 
            lblDR.AutoSize = true;
            lblDR.Location = new Point(92, 56);
            lblDR.Name = "lblDR";
            lblDR.Size = new Size(119, 15);
            lblDR.TabIndex = 77;
            lblDR.Text = "Descreção Resumida:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(652, 498);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(113, 47);
            btnNew.TabIndex = 76;
            btnNew.Text = "Novo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelet
            // 
            btnDelet.Location = new Point(497, 498);
            btnDelet.Name = "btnDelet";
            btnDelet.Size = new Size(113, 47);
            btnDelet.TabIndex = 75;
            btnDelet.Text = "Deletar";
            btnDelet.UseVisualStyleBackColor = true;
            btnDelet.Click += btnDelet_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(334, 498);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 47);
            btnEdit.TabIndex = 74;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(167, 498);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(113, 47);
            btnSalvar.TabIndex = 73;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgCP
            // 
            dgCP.AllowUserToAddRows = false;
            dgCP.AllowUserToDeleteRows = false;
            dgCP.BackgroundColor = SystemColors.ActiveCaption;
            dgCP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCP.Location = new Point(136, 290);
            dgCP.Name = "dgCP";
            dgCP.ReadOnly = true;
            dgCP.Size = new Size(681, 199);
            dgCP.TabIndex = 93;
            // 
            // rbPrazo
            // 
            rbPrazo.AutoSize = true;
            rbPrazo.Location = new Point(225, 265);
            rbPrazo.Name = "rbPrazo";
            rbPrazo.Size = new Size(65, 19);
            rbPrazo.TabIndex = 94;
            rbPrazo.TabStop = true;
            rbPrazo.Text = "Á prazo";
            rbPrazo.UseVisualStyleBackColor = true;
            // 
            // rbVista
            // 
            rbVista.AutoSize = true;
            rbVista.Location = new Point(137, 265);
            rbVista.Name = "rbVista";
            rbVista.Size = new Size(60, 19);
            rbVista.TabIndex = 95;
            rbVista.TabStop = true;
            rbVista.Text = "Á vista";
            rbVista.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(823, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(77, 25);
            btnAdd.TabIndex = 96;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(823, 321);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(77, 25);
            btnRemover.TabIndex = 97;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(662, 126);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(71, 23);
            txtQtd.TabIndex = 99;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(585, 130);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(72, 15);
            lblQtd.TabIndex = 98;
            lblQtd.Text = "Quantidade:";
            // 
            // lblCA
            // 
            lblCA.AutoSize = true;
            lblCA.Location = new Point(746, 126);
            lblCA.Name = "lblCA";
            lblCA.Size = new Size(26, 15);
            lblCA.TabIndex = 100;
            lblCA.Text = "CA:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(772, 121);
            maskedTextBox1.Mask = "99.999";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(34, 23);
            maskedTextBox1.TabIndex = 101;
            // 
            // frmCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 571);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblCA);
            Controls.Add(txtQtd);
            Controls.Add(lblQtd);
            Controls.Add(btnRemover);
            Controls.Add(btnAdd);
            Controls.Add(rbVista);
            Controls.Add(rbPrazo);
            Controls.Add(dgCP);
            Controls.Add(lblFornecedor);
            Controls.Add(cbFor);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtObs);
            Controls.Add(lblObs);
            Controls.Add(txtPV);
            Controls.Add(lblPV);
            Controls.Add(txtPP);
            Controls.Add(lblPP);
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
            Load += frmCadastrarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgCP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFornecedor;
        private ComboBox cbFor;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtObs;
        private Label lblObs;
        private TextBox txtPV;
        private Label lblPV;
        private TextBox txtPP;
        private Label lblPP;
        private TextBox txtDC;
        private Label lblDC;
        private TextBox txtDR;
        private Label lblDR;
        private Button btnNew;
        private Button btnDelet;
        private Button btnEdit;
        private Button btnSalvar;
        private DataGridView dgCP;
        private RadioButton rbPrazo;
        private RadioButton rbVista;
        private Button btnAdd;
        private Button btnRemover;
        private TextBox txtQtd;
        private Label lblQtd;
        private Label lblCA;
        private MaskedTextBox maskedTextBox1;
    }
}