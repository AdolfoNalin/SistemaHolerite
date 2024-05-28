namespace SistemaHolerite.VIEW
{
    partial class frmConsultarServico
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
            txtPesquisa = new TextBox();
            lblNome = new Label();
            btnPesquisa = new Button();
            dgServico = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgServico).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(98, 85);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(326, 23);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.KeyPress += txtPesquisa_KeyPress;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(53, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(433, 85);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(75, 23);
            btnPesquisa.TabIndex = 2;
            btnPesquisa.Text = "Pesquisa";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // dgServico
            // 
            dgServico.BackgroundColor = SystemColors.ActiveCaption;
            dgServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgServico.Location = new Point(12, 131);
            dgServico.Name = "dgServico";
            dgServico.Size = new Size(776, 307);
            dgServico.TabIndex = 3;
            // 
            // frmConsultarServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgServico);
            Controls.Add(btnPesquisa);
            Controls.Add(lblNome);
            Controls.Add(txtPesquisa);
            Name = "frmConsultarServico";
            Text = "Consultar Serviço";
            Load += frmConsultarServico_Load;
            ((System.ComponentModel.ISupportInitialize)dgServico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisa;
        private Label lblNome;
        private Button btnPesquisa;
        private DataGridView dgServico;
    }
}