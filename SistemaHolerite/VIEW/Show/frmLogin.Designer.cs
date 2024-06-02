namespace SistemaHolerite.VIEW.Show
{
    partial class frmLogin
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
            btnCancelar = new Button();
            btnEntrar = new Button();
            lblName = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(91, 144);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 32);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(249, 144);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(122, 32);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 58);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 2;
            lblName.Text = "NOME:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(57, 105);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(48, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "SENHA:";
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 55);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 23);
            txtName.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(111, 100);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(258, 23);
            txtSenha.TabIndex = 5;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 223);
            Controls.Add(txtSenha);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(btnEntrar);
            Controls.Add(btnCancelar);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnEntrar;
        private Label lblName;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtSenha;
    }
}