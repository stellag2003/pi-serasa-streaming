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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            lblSenha = new Label();
            lblEmail = new Label();
            label1 = new Label();
            painelU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // painelU
            // 
            painelU.BackColor = Color.Black;
            painelU.Controls.Add(pictureBox1);
            painelU.Controls.Add(label2);
            painelU.Controls.Add(btnEntrar);
            painelU.Controls.Add(txtSenha);
            painelU.Controls.Add(txtEmail);
            painelU.Controls.Add(lblSenha);
            painelU.Controls.Add(lblEmail);
            painelU.Controls.Add(label1);
            painelU.ForeColor = Color.CadetBlue;
            painelU.Location = new Point(52, 31);
            painelU.Name = "painelU";
            painelU.Size = new Size(372, 442);
            painelU.TabIndex = 0;
            painelU.Paint += painelU_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 395);
            label2.Name = "label2";
            label2.Size = new Size(211, 13);
            label2.TabIndex = 7;
            label2.Text = "Não possui uma conta? Criar uma conta";
            label2.Click += label2_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(126, 270);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(113, 26);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(43, 214);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(257, 23);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(43, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(43, 184);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(46, 17);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(43, 110);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 17);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(111, 75);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 0;
            label1.Text = "Login de Usuário";
            label1.Click += label1_Click;
            // 
            // TelaU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            BackgroundImage = Properties.Resources.papel_de_parede_login_editada1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(892, 485);
            Controls.Add(painelU);
            Name = "TelaU";
            Text = "TelaU";
            Load += TelaU_Load;
            painelU.ResumeLayout(false);
            painelU.PerformLayout();
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
        private PictureBox pictureBox1;
    }
}