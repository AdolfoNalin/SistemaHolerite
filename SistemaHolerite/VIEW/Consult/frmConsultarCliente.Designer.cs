namespace SistemaHolerite.VIEW
{
    partial class frmConsultarCliente
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
            dgCliente = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(141, 65);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(325, 23);
            txtPesquisar.TabIndex = 0;
            txtPesquisar.KeyPress += txtPesquisar_KeyPress;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(470, 65);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(86, 69);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 2;
            lblPesquisar.Text = "Pesquisar";
            // 
            // dgCliente
            // 
            dgCliente.BackgroundColor = SystemColors.ActiveCaption;
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Location = new Point(35, 113);
            dgCliente.Name = "dgCliente";
            dgCliente.Size = new Size(722, 307);
            dgCliente.TabIndex = 3;
            // 
            // frmConsultarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgCliente);
            Controls.Add(lblPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Name = "frmConsultarCliente";
            Text = "Consultar Cliente";
            Load += frmConsultarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lblPesquisar;
        public DataGridView dgCliente;
    }
}