namespace SistemaHolerite.VIEW
{
    partial class frmConsultarOrcamento
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
            dgOrcamento = new DataGridView();
            lblPesquisar = new Label();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgOrcamento).BeginInit();
            SuspendLayout();
            // 
            // dgOrcamento
            // 
            dgOrcamento.AllowUserToAddRows = false;
            dgOrcamento.AllowUserToDeleteRows = false;
            dgOrcamento.BackgroundColor = SystemColors.ActiveCaption;
            dgOrcamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOrcamento.GridColor = SystemColors.Highlight;
            dgOrcamento.Location = new Point(50, 88);
            dgOrcamento.Name = "dgOrcamento";
            dgOrcamento.ReadOnly = true;
            dgOrcamento.Size = new Size(701, 316);
            dgOrcamento.TabIndex = 7;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(50, 52);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(60, 15);
            lblPesquisar.TabIndex = 6;
            lblPesquisar.Text = "Pesquisar:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(396, 46);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(85, 27);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(116, 48);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(273, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // frmConsultarOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgOrcamento);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Name = "frmConsultarOrcamento";
            Text = "Consultar Orçamento";
            Load += frmConsultarOrcamento_Load;
            ((System.ComponentModel.ISupportInitialize)dgOrcamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dgOrcamento;
        private Label lblPesquisar;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
    }
}