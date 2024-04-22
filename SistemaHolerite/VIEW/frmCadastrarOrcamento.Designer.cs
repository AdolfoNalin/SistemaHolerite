namespace SistemaHolerite.VIEW
{
    partial class frmCadastrarOrcamento
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
            lblCliente = new Label();
            btnPesCliente = new Button();
            txtPesClient = new TextBox();
            dgOrcamento = new DataGridView();
            mtbData = new MaskedTextBox();
            txtId = new TextBox();
            lblId = new Label();
            txtDR = new TextBox();
            lblDR = new Label();
            btnPesDR = new Button();
            txtVP = new TextBox();
            lblValor = new Label();
            txtVV = new TextBox();
            lblVista = new Label();
            rbVista = new RadioButton();
            rbPrazo = new RadioButton();
            btnAddPro = new Button();
            txtTotal = new TextBox();
            lblTotal = new Label();
            txtSub = new TextBox();
            lblSub = new Label();
            btnImprimir = new Button();
            txtIdPro = new TextBox();
            label1 = new Label();
            brnRemover = new Button();
            txtQtd = new TextBox();
            lblQtd = new Label();
            ((System.ComponentModel.ISupportInitialize)dgOrcamento).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(81, 27);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // btnPesCliente
            // 
            btnPesCliente.Location = new Point(341, 24);
            btnPesCliente.Name = "btnPesCliente";
            btnPesCliente.Size = new Size(21, 23);
            btnPesCliente.TabIndex = 1;
            btnPesCliente.UseVisualStyleBackColor = true;
            // 
            // txtPesClient
            // 
            txtPesClient.Location = new Point(130, 23);
            txtPesClient.Name = "txtPesClient";
            txtPesClient.Size = new Size(207, 23);
            txtPesClient.TabIndex = 2;
            // 
            // dgOrcamento
            // 
            dgOrcamento.BackgroundColor = SystemColors.ActiveCaption;
            dgOrcamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrcamento.Location = new Point(341, 82);
            dgOrcamento.Name = "dgOrcamento";
            dgOrcamento.Size = new Size(556, 245);
            dgOrcamento.TabIndex = 3;
            // 
            // mtbData
            // 
            mtbData.Location = new Point(831, 24);
            mtbData.Mask = "00/00/0000";
            mtbData.Name = "mtbData";
            mtbData.Size = new Size(66, 23);
            mtbData.TabIndex = 4;
            mtbData.ValidatingType = typeof(DateTime);
            // 
            // txtId
            // 
            txtId.Location = new Point(508, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(38, 23);
            txtId.TabIndex = 6;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(473, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Cód:";
            // 
            // txtDR
            // 
            txtDR.Location = new Point(71, 105);
            txtDR.Name = "txtDR";
            txtDR.Size = new Size(149, 23);
            txtDR.TabIndex = 8;
            // 
            // lblDR
            // 
            lblDR.AutoSize = true;
            lblDR.Location = new Point(12, 108);
            lblDR.Name = "lblDR";
            lblDR.Size = new Size(61, 15);
            lblDR.TabIndex = 7;
            lblDR.Text = "Descrição:";
            // 
            // btnPesDR
            // 
            btnPesDR.Location = new Point(225, 105);
            btnPesDR.Name = "btnPesDR";
            btnPesDR.Size = new Size(21, 23);
            btnPesDR.TabIndex = 9;
            btnPesDR.UseVisualStyleBackColor = true;
            btnPesDR.Click += btnPesDR_Click;
            // 
            // txtVP
            // 
            txtVP.Location = new Point(81, 164);
            txtVP.Name = "txtVP";
            txtVP.Size = new Size(72, 23);
            txtVP.TabIndex = 11;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 167);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(68, 15);
            lblValor.TabIndex = 10;
            lblValor.Text = "Valor Prazo:";
            // 
            // txtVV
            // 
            txtVV.Location = new Point(234, 164);
            txtVV.Name = "txtVV";
            txtVV.Size = new Size(72, 23);
            txtVV.TabIndex = 13;
            // 
            // lblVista
            // 
            lblVista.AutoSize = true;
            lblVista.Location = new Point(165, 167);
            lblVista.Name = "lblVista";
            lblVista.Size = new Size(64, 15);
            lblVista.TabIndex = 12;
            lblVista.Text = "Valor Vista:";
            // 
            // rbVista
            // 
            rbVista.AutoSize = true;
            rbVista.Location = new Point(626, 21);
            rbVista.Name = "rbVista";
            rbVista.Size = new Size(50, 19);
            rbVista.TabIndex = 14;
            rbVista.TabStop = true;
            rbVista.Text = "Vista";
            rbVista.UseVisualStyleBackColor = true;
            // 
            // rbPrazo
            // 
            rbPrazo.AutoSize = true;
            rbPrazo.Location = new Point(626, 46);
            rbPrazo.Name = "rbPrazo";
            rbPrazo.Size = new Size(54, 19);
            rbPrazo.TabIndex = 15;
            rbPrazo.TabStop = true;
            rbPrazo.Text = "Prazo";
            rbPrazo.UseVisualStyleBackColor = true;
            // 
            // btnAddPro
            // 
            btnAddPro.Location = new Point(71, 215);
            btnAddPro.Name = "btnAddPro";
            btnAddPro.Size = new Size(86, 23);
            btnAddPro.TabIndex = 16;
            btnAddPro.Text = "Adicionar";
            btnAddPro.UseVisualStyleBackColor = true;
            btnAddPro.Click += button2_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(674, 376);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(72, 23);
            txtTotal.TabIndex = 20;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(634, 380);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "Total:";
            // 
            // txtSub
            // 
            txtSub.Location = new Point(675, 347);
            txtSub.Name = "txtSub";
            txtSub.Size = new Size(72, 23);
            txtSub.TabIndex = 18;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Location = new Point(615, 352);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(54, 15);
            lblSub.TabIndex = 17;
            lblSub.Text = "Subtotal:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(811, 380);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(86, 23);
            btnImprimir.TabIndex = 21;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtIdPro
            // 
            txtIdPro.Location = new Point(71, 76);
            txtIdPro.Name = "txtIdPro";
            txtIdPro.Size = new Size(38, 23);
            txtIdPro.TabIndex = 23;
            txtIdPro.KeyPress += txtIdPro_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 80);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 22;
            label1.Text = "Cód:";
            // 
            // brnRemover
            // 
            brnRemover.Location = new Point(208, 215);
            brnRemover.Name = "brnRemover";
            brnRemover.Size = new Size(86, 23);
            brnRemover.TabIndex = 24;
            brnRemover.Text = "Remover";
            brnRemover.UseVisualStyleBackColor = true;
            // 
            // txtQtd
            // 
            txtQtd.Location = new Point(297, 105);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(38, 23);
            txtQtd.TabIndex = 26;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.Location = new Point(262, 109);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(32, 15);
            lblQtd.TabIndex = 25;
            lblQtd.Text = "Cód:";
            // 
            // frmCadastrarOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 462);
            Controls.Add(txtQtd);
            Controls.Add(lblQtd);
            Controls.Add(brnRemover);
            Controls.Add(txtIdPro);
            Controls.Add(label1);
            Controls.Add(btnImprimir);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(txtSub);
            Controls.Add(lblSub);
            Controls.Add(btnAddPro);
            Controls.Add(rbPrazo);
            Controls.Add(rbVista);
            Controls.Add(txtVV);
            Controls.Add(lblVista);
            Controls.Add(txtVP);
            Controls.Add(lblValor);
            Controls.Add(btnPesDR);
            Controls.Add(txtDR);
            Controls.Add(lblDR);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(mtbData);
            Controls.Add(dgOrcamento);
            Controls.Add(txtPesClient);
            Controls.Add(btnPesCliente);
            Controls.Add(lblCliente);
            Name = "frmCadastrarOrcamento";
            Text = "Cadastrar Serviço";
            Load += frmCadastrarOrcamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgOrcamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private Button btnPesCliente;
        private TextBox txtPesClient;
        private DataGridView dgOrcamento;
        private MaskedTextBox mtbData;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtDR;
        private Label lblDR;
        private Button btnPesDR;
        private TextBox txtVP;
        private Label lblValor;
        private TextBox txtVV;
        private Label lblVista;
        private RadioButton rbVista;
        private RadioButton rbPrazo;
        private Button btnAddPro;
        private TextBox txtTotal;
        private Label lblTotal;
        private TextBox txtSub;
        private Label lblSub;
        private Button btnImprimir;
        private TextBox txtIdPro;
        private Label label1;
        private Button brnRemover;
        private TextBox txtQtd;
        private Label lblQtd;
    }
}