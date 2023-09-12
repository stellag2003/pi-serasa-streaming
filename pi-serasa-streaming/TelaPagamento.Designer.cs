namespace pi_serasa_streaming
{
    partial class TelaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.painelDados = new System.Windows.Forms.Panel();
            this.txtNome = new WiLBiT.WiLBiTTextBox();
            this.btnConfirmar = new WiLBiT.WiLBiTButton2();
            this.txtCVV = new WiLBiT.WiLBiTTextBox();
            this.txtCPF = new WiLBiT.WiLBiTTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCartao = new WiLBiT.WiLBiTTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.painelDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número do cartão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(67, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "CPF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(179, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(103, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Métodos de pagamento";
            // 
            // painelDados
            // 
            this.painelDados.Controls.Add(this.txtNome);
            this.painelDados.Controls.Add(this.btnConfirmar);
            this.painelDados.Controls.Add(this.txtCVV);
            this.painelDados.Controls.Add(this.txtCPF);
            this.painelDados.Controls.Add(this.label5);
            this.painelDados.Controls.Add(this.txtCartao);
            this.painelDados.Controls.Add(this.label1);
            this.painelDados.Controls.Add(this.label3);
            this.painelDados.Controls.Add(this.label2);
            this.painelDados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.painelDados.Location = new System.Drawing.Point(22, 105);
            this.painelDados.Name = "painelDados";
            this.painelDados.Size = new System.Drawing.Size(291, 388);
            this.painelDados.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtNome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtNome.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtNome.BackColor = System.Drawing.Color.Black;
            this.txtNome.BorderColor = System.Drawing.Color.Gray;
            this.txtNome.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtNome.BorderRadius = 4;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(67, 113);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNome.PlaceholderText = "Ex: Maria dos Santos";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(165, 29);
            this.txtNome.TabIndex = 15;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirmar.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.BorderRadius = 10;
            this.btnConfirmar.BorderSize = 2;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(86, 321);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(121, 40);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextColor = System.Drawing.Color.White;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // txtCVV
            // 
            this.txtCVV.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtCVV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtCVV.BackColor = System.Drawing.Color.Black;
            this.txtCVV.BorderColor = System.Drawing.Color.Gray;
            this.txtCVV.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtCVV.BorderRadius = 4;
            this.txtCVV.BorderSize = 2;
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.txtCVV.ForeColor = System.Drawing.Color.Gray;
            this.txtCVV.Location = new System.Drawing.Point(67, 260);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(4);
            this.txtCVV.Multiline = false;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCVV.PasswordChar = false;
            this.txtCVV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCVV.PlaceholderText = "Ex: 321";
            this.txtCVV.Size = new System.Drawing.Size(165, 29);
            this.txtCVV.TabIndex = 13;
            this.txtCVV.Texts = "";
            this.txtCVV.UnderlinedStyle = false;
            // 
            // txtCPF
            // 
            this.txtCPF.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtCPF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtCPF.BackColor = System.Drawing.Color.Black;
            this.txtCPF.BorderColor = System.Drawing.Color.Gray;
            this.txtCPF.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtCPF.BorderRadius = 4;
            this.txtCPF.BorderSize = 2;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.ForeColor = System.Drawing.Color.Gray;
            this.txtCPF.Location = new System.Drawing.Point(67, 191);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCPF.PlaceholderText = "Ex: 123.456.789-10";
            this.txtCPF.Size = new System.Drawing.Size(165, 29);
            this.txtCPF.TabIndex = 12;
            this.txtCPF.Texts = "";
            this.txtCPF.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(64, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "CVV";
            // 
            // txtCartao
            // 
            this.txtCartao.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txtCartao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtCartao.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtCartao.BackColor = System.Drawing.Color.Black;
            this.txtCartao.BorderColor = System.Drawing.Color.Gray;
            this.txtCartao.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtCartao.BorderRadius = 4;
            this.txtCartao.BorderSize = 2;
            this.txtCartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.txtCartao.ForeColor = System.Drawing.Color.Gray;
            this.txtCartao.Location = new System.Drawing.Point(67, 41);
            this.txtCartao.Margin = new System.Windows.Forms.Padding(0);
            this.txtCartao.Multiline = false;
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCartao.PasswordChar = false;
            this.txtCartao.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCartao.PlaceholderText = "Ex: 0000 0000 0000 0000";
            this.txtCartao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCartao.Size = new System.Drawing.Size(165, 29);
            this.txtCartao.TabIndex = 9;
            this.txtCartao.Texts = "";
            this.txtCartao.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.painelDados);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(222, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 512);
            this.panel1.TabIndex = 13;
            // 
            // TelaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(805, 578);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPagamento";
            this.Text = "TelaPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.painelDados.ResumeLayout(false);
            this.painelDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Panel painelDados;
        private WiLBiT.WiLBiTTextBox txtCartao;
        private Label label5;
        private WiLBiT.WiLBiTTextBox txtCVV;
        private WiLBiT.WiLBiTTextBox txtCPF;
        private Panel panel1;
        private WiLBiT.WiLBiTButton2 btnConfirmar;
        private WiLBiT.WiLBiTTextBox txtNome;
    }
}