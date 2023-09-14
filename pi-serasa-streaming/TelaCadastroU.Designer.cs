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
            this.painelCadastro = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTermos = new System.Windows.Forms.RadioButton();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCadastro
            // 
            this.painelCadastro.BackColor = System.Drawing.Color.Black;
            this.painelCadastro.Controls.Add(this.txtSenha);
            this.painelCadastro.Controls.Add(this.txtData);
            this.painelCadastro.Controls.Add(this.button1);
            this.painelCadastro.Controls.Add(this.btnTermos);
            this.painelCadastro.Controls.Add(this.comboGenero);
            this.painelCadastro.Controls.Add(this.txtEmail);
            this.painelCadastro.Controls.Add(this.txtNome);
            this.painelCadastro.Controls.Add(this.label5);
            this.painelCadastro.Controls.Add(this.label4);
            this.painelCadastro.Controls.Add(this.label3);
            this.painelCadastro.Controls.Add(this.label2);
            this.painelCadastro.Controls.Add(this.lblEmail);
            this.painelCadastro.Controls.Add(this.label1);
            this.painelCadastro.Location = new System.Drawing.Point(178, 23);
            this.painelCadastro.Name = "painelCadastro";
            this.painelCadastro.Size = new System.Drawing.Size(396, 597);
            this.painelCadastro.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(52, 295);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(268, 23);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(52, 357);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(267, 23);
            this.txtData.TabIndex = 4;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTermos
            // 
            this.btnTermos.AutoSize = true;
            this.btnTermos.ForeColor = System.Drawing.Color.White;
            this.btnTermos.Location = new System.Drawing.Point(16, 484);
            this.btnTermos.Name = "btnTermos";
            this.btnTermos.Size = new System.Drawing.Size(366, 19);
            this.btnTermos.TabIndex = 19;
            this.btnTermos.Text = "Eu li e concordo com os Termos de Uso e Política de Privacidade.";
            this.btnTermos.UseVisualStyleBackColor = true;
            // 
            // comboGenero
            // 
            this.comboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "feminino\t",
            "masculino",
            "prefiro não declarar"});
            this.comboGenero.Location = new System.Drawing.Point(52, 419);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(267, 23);
            this.comboGenero.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(51, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(51, 168);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(268, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gênero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de nascimento: Ex-(ano-mês-dia)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(49, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // TelaCadastroU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.painelCadastro);
            this.Name = "TelaCadastroU";
            this.Text = " ";
            this.Load += new System.EventHandler(this.TelaCadastroU_Load);
            this.painelCadastro.ResumeLayout(false);
            this.painelCadastro.PerformLayout();
            this.ResumeLayout(false);

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
    }
}