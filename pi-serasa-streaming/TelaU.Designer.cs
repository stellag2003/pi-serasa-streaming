namespace pi_serasa_streaming
{
    partial class TelaU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaU));
            painelU = new Panel();
            label2 = new Label();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            label1 = new Label();
            menu = new Panel();
            pictureBox1 = new PictureBox();
            painelU.SuspendLayout();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // painelU
            // 
            painelU.BackColor = Color.Black;
            painelU.Controls.Add(label2);
            painelU.Controls.Add(btnEntrar);
            painelU.Controls.Add(txtSenha);
            painelU.Controls.Add(txtEmail);
            painelU.Controls.Add(lblSenha);
            painelU.Controls.Add(lblEmail);
            painelU.Controls.Add(label1);
            painelU.ForeColor = Color.CadetBlue;
            painelU.Location = new Point(48, 54);
            painelU.Name = "painelU";
            painelU.Size = new Size(369, 373);
            painelU.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 344);
            label2.Name = "label2";
            label2.Size = new Size(211, 13);
            label2.TabIndex = 7;
            label2.Text = "Não possui uma conta? Criar uma conta";
            label2.Click += label2_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(126, 215);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(100, 23);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(43, 163);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(257, 23);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 91);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(44, 143);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 17);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(43, 71);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 17);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 22);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Login de Usuário";
            // 
            // menu
            // 
            menu.Controls.Add(pictureBox1);
            menu.Location = new Point(454, 54);
            menu.Name = "menu";
            menu.Size = new Size(382, 174);
            menu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TelaU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(892, 485);
            Controls.Add(menu);
            Controls.Add(painelU);
            Name = "TelaU";
            Text = "TelaU";
            Load += TelaU_Load;
            painelU.ResumeLayout(false);
            painelU.PerformLayout();
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelU;
        private Button btnEntrar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Label lblSenha;
        private Label lblEmail;
        private Label label1;
        private Label label2;
        private Panel menu;
        private PictureBox pictureBox1;
    }
}