namespace SistemaHolerite.VIEW.Insert
{
    partial class frmCadastrarPoint
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
            dgItemPonto = new DataGridView();
            data = new DataGridViewTextBoxColumn();
            entrada = new DataGridViewTextBoxColumn();
            saidaAlmoco = new DataGridViewTextBoxColumn();
            entradaAlmoco = new DataGridViewTextBoxColumn();
            saida = new DataGridViewTextBoxColumn();
            entraExtra = new DataGridViewTextBoxColumn();
            saidaExtra = new DataGridViewTextBoxColumn();
            gbEmployee = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            lblCPF = new Label();
            lblCargo = new Label();
            txtCargo = new TextBox();
            btnConsultEmployee = new Button();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            lblNome = new Label();
            txtNameEmployee = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgItemPonto).BeginInit();
            gbEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // dgItemPonto
            // 
            dgItemPonto.AllowUserToAddRows = false;
            dgItemPonto.AllowUserToDeleteRows = false;
            dgItemPonto.BackgroundColor = SystemColors.ActiveCaption;
            dgItemPonto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemPonto.Columns.AddRange(new DataGridViewColumn[] { data, entrada, saidaAlmoco, entradaAlmoco, saida, entraExtra, saidaExtra });
            dgItemPonto.GridColor = SystemColors.MenuHighlight;
            dgItemPonto.Location = new Point(34, 165);
            dgItemPonto.Name = "dgItemPonto";
            dgItemPonto.ReadOnly = true;
            dgItemPonto.Size = new Size(665, 309);
            dgItemPonto.TabIndex = 0;
            // 
            // data
            // 
            data.HeaderText = "Data";
            data.Name = "data";
            data.ReadOnly = true;
            data.Width = 60;
            // 
            // entrada
            // 
            entrada.HeaderText = "Entrada";
            entrada.Name = "entrada";
            entrada.ReadOnly = true;
            entrada.Width = 60;
            // 
            // saidaAlmoco
            // 
            saidaAlmoco.HeaderText = "Saida Almoço";
            saidaAlmoco.Name = "saidaAlmoco";
            saidaAlmoco.ReadOnly = true;
            saidaAlmoco.Width = 120;
            // 
            // entradaAlmoco
            // 
            entradaAlmoco.HeaderText = "Entrada Almoço";
            entradaAlmoco.Name = "entradaAlmoco";
            entradaAlmoco.ReadOnly = true;
            entradaAlmoco.Width = 115;
            // 
            // saida
            // 
            saida.HeaderText = "Saida";
            saida.Name = "saida";
            saida.ReadOnly = true;
            saida.Width = 60;
            // 
            // entraExtra
            // 
            entraExtra.HeaderText = "Entra Extra";
            entraExtra.Name = "entraExtra";
            entraExtra.ReadOnly = true;
            entraExtra.Width = 110;
            // 
            // saidaExtra
            // 
            saidaExtra.HeaderText = "Saida Extra";
            saidaExtra.Name = "saidaExtra";
            saidaExtra.ReadOnly = true;
            // 
            // gbEmployee
            // 
            gbEmployee.Controls.Add(maskedTextBox1);
            gbEmployee.Controls.Add(lblCPF);
            gbEmployee.Controls.Add(lblCargo);
            gbEmployee.Controls.Add(txtCargo);
            gbEmployee.Controls.Add(btnConsultEmployee);
            gbEmployee.Controls.Add(lblEndereco);
            gbEmployee.Controls.Add(txtEndereco);
            gbEmployee.Controls.Add(lblNome);
            gbEmployee.Controls.Add(txtNameEmployee);
            gbEmployee.Location = new Point(12, 12);
            gbEmployee.Name = "gbEmployee";
            gbEmployee.Size = new Size(698, 125);
            gbEmployee.TabIndex = 2;
            gbEmployee.TabStop = false;
            gbEmployee.Text = "Funcionário";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(538, 26);
            maskedTextBox1.Mask = "999,999,999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(76, 23);
            maskedTextBox1.TabIndex = 9;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(505, 29);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 8;
            lblCPF.Text = "CPF:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(494, 84);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(42, 15);
            lblCargo.TabIndex = 6;
            lblCargo.Text = "Cargo:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(538, 81);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(138, 23);
            txtCargo.TabIndex = 5;
            // 
            // btnConsultEmployee
            // 
            btnConsultEmployee.Location = new Point(334, 30);
            btnConsultEmployee.Name = "btnConsultEmployee";
            btnConsultEmployee.Size = new Size(35, 23);
            btnConsultEmployee.TabIndex = 4;
            btnConsultEmployee.UseVisualStyleBackColor = true;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(22, 84);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(59, 15);
            lblEndereco.TabIndex = 3;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(84, 81);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(381, 23);
            txtEndereco.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // txtNameEmployee
            // 
            txtNameEmployee.Location = new Point(66, 31);
            txtNameEmployee.Name = "txtNameEmployee";
            txtNameEmployee.Size = new Size(262, 23);
            txtNameEmployee.TabIndex = 0;
            // 
            // frmCadastrarPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 513);
            Controls.Add(gbEmployee);
            Controls.Add(dgItemPonto);
            Name = "frmCadastrarPoint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Ponto";
            Load += frmCadastrarPoint_Load;
            ((System.ComponentModel.ISupportInitialize)dgItemPonto).EndInit();
            gbEmployee.ResumeLayout(false);
            gbEmployee.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgItemPonto;
        private GroupBox gbEmployee;
        private Label lblNome;
        private TextBox txtNameEmployee;
        private Button btnConsultEmployee;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private Label lblCargo;
        private TextBox txtCargo;
        private Label lblCPF;
        private MaskedTextBox maskedTextBox1;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn entrada;
        private DataGridViewTextBoxColumn saidaAlmoco;
        private DataGridViewTextBoxColumn entradaAlmoco;
        private DataGridViewTextBoxColumn saida;
        private DataGridViewTextBoxColumn entraExtra;
        private DataGridViewTextBoxColumn saidaExtra;
    }
}