namespace pi_serasa_streaming
{
    partial class TelaCadastroU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroU));
            painelCadastro = new Panel();
            pictureBox1 = new PictureBox();
            txtSenha = new TextBox();
            txtData = new MaskedTextBox();
            button1 = new Button();
            btnTermos = new RadioButton();
            comboGenero = new ComboBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblEmail = new Label();
            label1 = new Label();
            painelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // painelCadastro
            // 
            painelCadastro.BackColor = Color.Black;
            painelCadastro.Controls.Add(pictureBox1);
            painelCadastro.Controls.Add(txtSenha);
            painelCadastro.Controls.Add(txtData);
            painelCadastro.Controls.Add(button1);
            painelCadastro.Controls.Add(btnTermos);
            painelCadastro.Controls.Add(comboGenero);
            painelCadastro.Controls.Add(txtEmail);
            painelCadastro.Controls.Add(txtNome);
            painelCadastro.Controls.Add(label5);
            painelCadastro.Controls.Add(label4);
            painelCadastro.Controls.Add(label3);
            painelCadastro.Controls.Add(label2);
            painelCadastro.Controls.Add(lblEmail);
            painelCadastro.Controls.Add(label1);
            painelCadastro.Location = new Point(28, 29);
            painelCadastro.Name = "painelCadastro";
            painelCadastro.Size = new Size(396, 597);
            painelCadastro.TabIndex = 0;
            painelCadastro.Paint += painelCadastro_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(52, 295);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(268, 23);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtData
            // 
            txtData.Location = new Point(52, 357);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(267, 23);
            txtData.TabIndex = 4;
            txtData.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Location = new Point(112, 542);
            button1.Name = "button1";
            button1.Size = new Size(142, 27);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnTermos
            // 
            btnTermos.AutoSize = true;
            btnTermos.ForeColor = Color.White;
            btnTermos.Location = new Point(16, 484);
            btnTermos.Name = "btnTermos";
            btnTermos.Size = new Size(366, 19);
            btnTermos.TabIndex = 6;
            btnTermos.Text = "Eu li e concordo com os Termos de Uso e Política de Privacidade.";
            btnTermos.UseVisualStyleBackColor = true;
            // 
            // comboGenero
            // 
            comboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGenero.FlatStyle = FlatStyle.Flat;
            comboGenero.FormattingEnabled = true;
            comboGenero.Items.AddRange(new object[] { "feminino\t", "masculino", "prefiro não declarar" });
            comboGenero.Location = new Point(52, 419);
            comboGenero.Name = "comboGenero";
            comboGenero.Size = new Size(267, 23);
            comboGenero.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(51, 229);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(51, 168);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(268, 23);
            txtNome.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 399);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 6;
            label5.Text = "Gênero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(52, 337);
            label4.Name = "label4";
            label4.Size = new Size(131, 17);
            label4.TabIndex = 5;
            label4.Text = "Data de nascimento: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(52, 275);
            label3.Name = "label3";
            label3.Size = new Size(46, 17);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 209);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 3;
            label2.Text = "E-mail:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(49, 148);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 17);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(112, 90);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Usuário";
            // 
            // TelaCadastroU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.capa_cadastro_editada1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 647);
            Controls.Add(painelCadastro);
            Name = "TelaCadastroU";
            Text = " ";
            Load += TelaCadastroU_Load;
            painelCadastro.ResumeLayout(false);
            painelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel painelCadastro;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblEmail;
        private Button button1;
        private RadioButton btnTermos;
        private ComboBox comboGenero;
        private TextBox txtEmail;
        private TextBox txtNome;
        private MaskedTextBox txtData;
        private TextBox txtSenha;
        private PictureBox pictureBox1;
    }
}