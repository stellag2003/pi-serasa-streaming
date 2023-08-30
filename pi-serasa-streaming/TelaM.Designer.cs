namespace pi_serasa_streaming
{
    partial class TelaM
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
            this.painelM = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPassaword = new System.Windows.Forms.TextBox();
            this.lblPassaword = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblModerador = new System.Windows.Forms.Label();
            this.painelM.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelM
            // 
            this.painelM.BackColor = System.Drawing.Color.Black;
            this.painelM.Controls.Add(this.btnEntrar);
            this.painelM.Controls.Add(this.txtPassaword);
            this.painelM.Controls.Add(this.lblPassaword);
            this.painelM.Controls.Add(this.txtUsuario);
            this.painelM.Controls.Add(this.lblUsuario);
            this.painelM.Controls.Add(this.lblModerador);
            this.painelM.Location = new System.Drawing.Point(213, 110);
            this.painelM.Name = "painelM";
            this.painelM.Size = new System.Drawing.Size(376, 298);
            this.painelM.TabIndex = 0;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(115, 235);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(158, 30);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPassaword
            // 
            this.txtPassaword.Location = new System.Drawing.Point(39, 177);
            this.txtPassaword.Name = "txtPassaword";
            this.txtPassaword.PasswordChar = '*';
            this.txtPassaword.Size = new System.Drawing.Size(280, 23);
            this.txtPassaword.TabIndex = 4;
            this.txtPassaword.UseSystemPasswordChar = true;
            // 
            // lblPassaword
            // 
            this.lblPassaword.AutoSize = true;
            this.lblPassaword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassaword.ForeColor = System.Drawing.Color.White;
            this.lblPassaword.Location = new System.Drawing.Point(39, 157);
            this.lblPassaword.Name = "lblPassaword";
            this.lblPassaword.Size = new System.Drawing.Size(46, 17);
            this.lblPassaword.TabIndex = 3;
            this.lblPassaword.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(39, 108);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(280, 23);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(39, 88);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 17);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblModerador
            // 
            this.lblModerador.AutoSize = true;
            this.lblModerador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModerador.ForeColor = System.Drawing.Color.White;
            this.lblModerador.Location = new System.Drawing.Point(115, 21);
            this.lblModerador.Name = "lblModerador";
            this.lblModerador.Size = new System.Drawing.Size(131, 21);
            this.lblModerador.TabIndex = 0;
            this.lblModerador.Text = "Login Moderador";
            // 
            // TelaM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelM);
            this.Name = "TelaM";
            this.Text = "TelaM";
            this.Load += new System.EventHandler(this.TelaM_Load);
            this.painelM.ResumeLayout(false);
            this.painelM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel painelM;
        private Label lblUsuario;
        private Label lblModerador;
        private TextBox txtUsuario;
        private Button btnEntrar;
        private TextBox txtPassaword;
        private Label lblPassaword;
    }
}