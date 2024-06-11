namespace SistemaHolerite.VIEW
{
    partial class frmHolerite
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
            lblFuncionario = new Label();
            btnConsulta = new Button();
            txtNome = new TextBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            lblEmpregador = new Label();
            lblCNPJ = new Label();
            maskedTextBox1 = new MaskedTextBox();
            lblFolhaPG = new Label();
            gbEmpregador = new GroupBox();
            mtbCelular = new MaskedTextBox();
            lblEnd = new Label();
            txtMun = new TextBox();
            comboBox1 = new ComboBox();
            gbFuncionario = new GroupBox();
            txtDataRef = new TextBox();
            lblReferencia = new Label();
            maskedTextBox2 = new MaskedTextBox();
            lblAdmissao = new Label();
            lblFuncao = new Label();
            textBox2 = new TextBox();
            mtbCBO = new MaskedTextBox();
            lblCBO = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbEmpregador.SuspendLayout();
            gbFuncionario.SuspendLayout();
            SuspendLayout();
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Location = new Point(6, 26);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(73, 15);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "Funcionário:";
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(332, 41);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(36, 29);
            btnConsulta.TabIndex = 1;
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(320, 23);
            txtNome.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(110, 323);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(937, 300);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 7;
            // 
            // lblEmpregador
            // 
            lblEmpregador.AutoSize = true;
            lblEmpregador.Location = new Point(20, 27);
            lblEmpregador.Name = "lblEmpregador";
            lblEmpregador.Size = new Size(75, 15);
            lblEmpregador.TabIndex = 6;
            lblEmpregador.Text = "Empregador:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.Location = new Point(825, 71);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(37, 15);
            lblCNPJ.TabIndex = 8;
            lblCNPJ.Text = "CNPJ:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(825, 89);
            maskedTextBox1.Mask = "99,999,999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(70, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // lblFolhaPG
            // 
            lblFolhaPG.AutoSize = true;
            lblFolhaPG.Location = new Point(825, 19);
            lblFolhaPG.Name = "lblFolhaPG";
            lblFolhaPG.Size = new Size(106, 15);
            lblFolhaPG.TabIndex = 10;
            lblFolhaPG.Text = "Folha de Pamento:";
            // 
            // gbEmpregador
            // 
            gbEmpregador.Controls.Add(mtbCelular);
            gbEmpregador.Controls.Add(lblEnd);
            gbEmpregador.Controls.Add(txtMun);
            gbEmpregador.Controls.Add(comboBox1);
            gbEmpregador.Controls.Add(lblEmpregador);
            gbEmpregador.Controls.Add(textBox1);
            gbEmpregador.Controls.Add(lblFolhaPG);
            gbEmpregador.Controls.Add(maskedTextBox1);
            gbEmpregador.Controls.Add(lblCNPJ);
            gbEmpregador.Location = new Point(110, 12);
            gbEmpregador.Name = "gbEmpregador";
            gbEmpregador.Size = new Size(937, 132);
            gbEmpregador.TabIndex = 12;
            gbEmpregador.TabStop = false;
            gbEmpregador.Text = "Empregador";
            // 
            // mtbCelular
            // 
            mtbCelular.Location = new Point(521, 95);
            mtbCelular.Mask = "(99) 99999-9999";
            mtbCelular.Name = "mtbCelular";
            mtbCelular.Size = new Size(78, 23);
            mtbCelular.TabIndex = 14;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(20, 77);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(59, 15);
            lblEnd.TabIndex = 12;
            lblEnd.Text = "Endereço:";
            // 
            // txtMun
            // 
            txtMun.Location = new Point(20, 95);
            txtMun.Name = "txtMun";
            txtMun.Size = new Size(480, 23);
            txtMun.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "MENSAL", "SEMANAL", "DIARIÁ" });
            comboBox1.Location = new Point(825, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 23);
            comboBox1.TabIndex = 11;
            // 
            // gbFuncionario
            // 
            gbFuncionario.Controls.Add(txtDataRef);
            gbFuncionario.Controls.Add(lblReferencia);
            gbFuncionario.Controls.Add(maskedTextBox2);
            gbFuncionario.Controls.Add(lblAdmissao);
            gbFuncionario.Controls.Add(lblFuncao);
            gbFuncionario.Controls.Add(textBox2);
            gbFuncionario.Controls.Add(mtbCBO);
            gbFuncionario.Controls.Add(lblCBO);
            gbFuncionario.Controls.Add(txtNome);
            gbFuncionario.Controls.Add(lblFuncionario);
            gbFuncionario.Controls.Add(btnConsulta);
            gbFuncionario.Location = new Point(110, 150);
            gbFuncionario.Name = "gbFuncionario";
            gbFuncionario.Size = new Size(937, 149);
            gbFuncionario.TabIndex = 12;
            gbFuncionario.TabStop = false;
            gbFuncionario.Text = "Funcionário";
            // 
            // txtDataRef
            // 
            txtDataRef.Location = new Point(833, 102);
            txtDataRef.Name = "txtDataRef";
            txtDataRef.Size = new Size(65, 23);
            txtDataRef.TabIndex = 17;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Location = new Point(830, 84);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(65, 15);
            lblReferencia.TabIndex = 16;
            lblReferencia.Text = "Referência:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(836, 47);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(62, 23);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // lblAdmissao
            // 
            lblAdmissao.AutoSize = true;
            lblAdmissao.Location = new Point(833, 26);
            lblAdmissao.Name = "lblAdmissao";
            lblAdmissao.Size = new Size(62, 15);
            lblAdmissao.TabIndex = 15;
            lblAdmissao.Text = "Admissão:";
            // 
            // lblFuncao
            // 
            lblFuncao.AutoSize = true;
            lblFuncao.Location = new Point(93, 84);
            lblFuncao.Name = "lblFuncao";
            lblFuncao.Size = new Size(49, 15);
            lblFuncao.TabIndex = 13;
            lblFuncao.Text = "Função:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 23);
            textBox2.TabIndex = 14;
            // 
            // mtbCBO
            // 
            mtbCBO.Location = new Point(9, 102);
            mtbCBO.Mask = "9999-99";
            mtbCBO.Name = "mtbCBO";
            mtbCBO.Size = new Size(43, 23);
            mtbCBO.TabIndex = 12;
            // 
            // lblCBO
            // 
            lblCBO.AutoSize = true;
            lblCBO.Location = new Point(6, 84);
            lblCBO.Name = "lblCBO";
            lblCBO.Size = new Size(34, 15);
            lblCBO.TabIndex = 3;
            lblCBO.Text = "CBO:";
            // 
            // frmHolerite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1253, 635);
            Controls.Add(gbFuncionario);
            Controls.Add(gbEmpregador);
            Controls.Add(dataGridView1);
            Name = "frmHolerite";
            Text = "Holerite";
            Load += frmHolerite_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbEmpregador.ResumeLayout(false);
            gbEmpregador.PerformLayout();
            gbFuncionario.ResumeLayout(false);
            gbFuncionario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFuncionario;
        private Button btnConsulta;
        private TextBox txtNome;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label lblEmpregador;
        private Label lblCNPJ;
        private MaskedTextBox maskedTextBox1;
        private Label lblFolhaPG;
        private GroupBox gbEmpregador;
        private GroupBox gbFuncionario;
        private ComboBox comboBox1;
        private Label lblCBO;
        private MaskedTextBox mtbCBO;
        private Label lblFuncao;
        private TextBox textBox2;
        private Label lblReferencia;
        private MaskedTextBox maskedTextBox2;
        private Label lblAdmissao;
        private MaskedTextBox mtbCelular;
        private Label lblEnd;
        private TextBox txtMun;
        private TextBox txtDataRef;
    }
}