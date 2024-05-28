namespace SistemaHolerite.VIEW
{
    partial class frmConsultarFuncionario
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
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lblPesquisar = new Label();
            dgFuncionario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(123, 29);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(273, 23);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(403, 27);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(85, 27);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(57, 33);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(60, 15);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // dgFuncionario
            // 
            dgFuncionario.AllowUserToAddRows = false;
            dgFuncionario.AllowUserToDeleteRows = false;
            dgFuncionario.BackgroundColor = SystemColors.ActiveCaption;
            dgFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgFuncionario.GridColor = SystemColors.Highlight;
            dgFuncionario.Location = new Point(57, 69);
            dgFuncionario.Name = "dgFuncionario";
            dgFuncionario.ReadOnly = true;
            dgFuncionario.Size = new Size(701, 316);
            dgFuncionario.TabIndex = 3;
            // 
            // frmConsultarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgFuncionario);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Name = "frmConsultarFuncionario";
            Text = "Consultar Funcionario";
            Load += frmConsultarFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)dgFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblPesquisar;
        public DataGridView dgFuncionario;
    }
}