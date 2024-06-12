namespace SistemaHolerite.VIEW.Consult
{
    partial class frmConsultarPonto
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
            lblMes = new Label();
            maskedTextBox1 = new MaskedTextBox();
            dgFuncionario = new DataGridView();
            btnPesquisarM = new Button();
            txtNome = new TextBox();
            lblNome = new Label();
            btnConsultar = new Button();
            btnPNome = new Button();
            ((System.ComponentModel.ISupportInitialize)dgFuncionario).BeginInit();
            SuspendLayout();
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(558, 38);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(32, 15);
            lblMes.TabIndex = 0;
            lblMes.Text = "Mês:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(591, 35);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(57, 23);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // dgFuncionario
            // 
            dgFuncionario.AllowUserToAddRows = false;
            dgFuncionario.AllowUserToDeleteRows = false;
            dgFuncionario.BackgroundColor = SystemColors.ActiveCaption;
            dgFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFuncionario.Location = new Point(63, 103);
            dgFuncionario.Name = "dgFuncionario";
            dgFuncionario.ReadOnly = true;
            dgFuncionario.Size = new Size(666, 260);
            dgFuncionario.TabIndex = 2;
            // 
            // btnPesquisarM
            // 
            btnPesquisarM.Location = new Point(654, 35);
            btnPesquisarM.Name = "btnPesquisarM";
            btnPesquisarM.Size = new Size(75, 23);
            btnPesquisarM.TabIndex = 3;
            btnPesquisarM.Text = "Pesquisar";
            btnPesquisarM.UseVisualStyleBackColor = true;
            btnPesquisarM.Click += btnPesquisarM_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(108, 36);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(302, 23);
            txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(63, 39);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(412, 36);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(32, 23);
            btnConsultar.TabIndex = 6;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnPNome
            // 
            btnPNome.Location = new Point(450, 36);
            btnPNome.Name = "btnPNome";
            btnPNome.Size = new Size(75, 23);
            btnPNome.TabIndex = 7;
            btnPNome.Text = "Pesquisar";
            btnPNome.UseVisualStyleBackColor = true;
            btnPNome.Click += btnPNome_Click;
            // 
            // frmConsultarPonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPNome);
            Controls.Add(btnConsultar);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(btnPesquisarM);
            Controls.Add(dgFuncionario);
            Controls.Add(maskedTextBox1);
            Controls.Add(lblMes);
            Name = "frmConsultarPonto";
            Text = "Consultar Ponto";
            Load += frmConsultarHolerite_Load;
            ((System.ComponentModel.ISupportInitialize)dgFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMes;
        private MaskedTextBox maskedTextBox1;
        private DataGridView dgFuncionario;
        private Button btnPesquisarM;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnConsultar;
        private Button btnPNome;
    }
}