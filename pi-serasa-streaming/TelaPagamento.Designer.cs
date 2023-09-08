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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            painelDados = new Panel();
            txtNome = new WiLBiT.WiLBiTTextBox();
            btnConfirmar = new WiLBiT.WiLBiTButton2();
            txtCVV = new WiLBiT.WiLBiTTextBox();
            txtCPF = new WiLBiT.WiLBiTTextBox();
            label5 = new Label();
            txtCartao = new WiLBiT.WiLBiTTextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            painelDados.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(67, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 17);
            label1.TabIndex = 5;
            label1.Text = "Número do cartão";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 92);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 6;
            label2.Text = "Nome do titular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(67, 170);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 7;
            label3.Text = "CPF";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(179, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(103, 24);
            label4.Name = "label4";
            label4.Size = new Size(151, 17);
            label4.TabIndex = 11;
            label4.Text = "Métodos de pagamento";
            // 
            // painelDados
            // 
            painelDados.Controls.Add(txtNome);
            painelDados.Controls.Add(btnConfirmar);
            painelDados.Controls.Add(txtCVV);
            painelDados.Controls.Add(txtCPF);
            painelDados.Controls.Add(label5);
            painelDados.Controls.Add(txtCartao);
            painelDados.Controls.Add(label1);
            painelDados.Controls.Add(label3);
            painelDados.Controls.Add(label2);
            painelDados.ForeColor = SystemColors.ButtonFace;
            painelDados.Location = new Point(22, 105);
            painelDados.Name = "painelDados";
            painelDados.Size = new Size(291, 388);
            painelDados.TabIndex = 12;
            painelDados.Paint += panel1_Paint;
            // 
            // txtNome
            // 
            txtNome.AccessibleRole = AccessibleRole.Grip;
            txtNome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtNome.AutoValidate = AutoValidate.EnableAllowFocusChange;
            txtNome.BackColor = Color.Black;
            txtNome.BorderColor = Color.Gray;
            txtNome.BorderFocusColor = Color.DimGray;
            txtNome.BorderRadius = 4;
            txtNome.BorderSize = 2;
            txtNome.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Underline, GraphicsUnit.Point);
            txtNome.ForeColor = Color.Gray;
            txtNome.Location = new Point(67, 113);
            txtNome.Margin = new Padding(4);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Padding = new Padding(10, 7, 10, 7);
            txtNome.PasswordChar = false;
            txtNome.PlaceholderColor = Color.DarkGray;
            txtNome.PlaceholderText = "Ex: Maria dos Santos";
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.Size = new Size(165, 29);
            txtNome.TabIndex = 15;
            txtNome.Texts = "";
            txtNome.UnderlinedStyle = false;
            txtNome._TextChanged += txtNome__TextChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaptionText;
            btnConfirmar.BackgroundColor = SystemColors.ActiveCaptionText;
            btnConfirmar.BorderColor = Color.Red;
            btnConfirmar.BorderRadius = 10;
            btnConfirmar.BorderSize = 2;
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(86, 321);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(121, 40);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.TextColor = Color.White;
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtCVV
            // 
            txtCVV.AccessibleRole = AccessibleRole.Grip;
            txtCVV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCVV.BackColor = Color.Black;
            txtCVV.BorderColor = Color.Gray;
            txtCVV.BorderFocusColor = Color.DimGray;
            txtCVV.BorderRadius = 4;
            txtCVV.BorderSize = 2;
            txtCVV.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Underline, GraphicsUnit.Point);
            txtCVV.ForeColor = Color.Gray;
            txtCVV.Location = new Point(67, 260);
            txtCVV.Margin = new Padding(4);
            txtCVV.Multiline = false;
            txtCVV.Name = "txtCVV";
            txtCVV.Padding = new Padding(10, 7, 10, 7);
            txtCVV.PasswordChar = false;
            txtCVV.PlaceholderColor = Color.DarkGray;
            txtCVV.PlaceholderText = "Ex: 321";
            txtCVV.Size = new Size(165, 29);
            txtCVV.TabIndex = 13;
            txtCVV.Texts = "";
            txtCVV.UnderlinedStyle = false;
            // 
            // txtCPF
            // 
            txtCPF.AccessibleRole = AccessibleRole.Grip;
            txtCPF.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCPF.BackColor = Color.Black;
            txtCPF.BorderColor = Color.Gray;
            txtCPF.BorderFocusColor = Color.DimGray;
            txtCPF.BorderRadius = 4;
            txtCPF.BorderSize = 2;
            txtCPF.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Underline, GraphicsUnit.Point);
            txtCPF.ForeColor = Color.Gray;
            txtCPF.Location = new Point(67, 191);
            txtCPF.Margin = new Padding(4);
            txtCPF.Multiline = false;
            txtCPF.Name = "txtCPF";
            txtCPF.Padding = new Padding(10, 7, 10, 7);
            txtCPF.PasswordChar = false;
            txtCPF.PlaceholderColor = Color.DarkGray;
            txtCPF.PlaceholderText = "Ex: 123.456.789-10";
            txtCPF.Size = new Size(165, 29);
            txtCPF.TabIndex = 12;
            txtCPF.Texts = "";
            txtCPF.UnderlinedStyle = false;
            txtCPF._TextChanged += wilBitTextBox1__TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(64, 239);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 10;
            label5.Text = "CVV";
            // 
            // txtCartao
            // 
            txtCartao.AccessibleRole = AccessibleRole.Grip;
            txtCartao.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            txtCartao.AutoValidate = AutoValidate.EnableAllowFocusChange;
            txtCartao.BackColor = Color.Black;
            txtCartao.BorderColor = Color.Gray;
            txtCartao.BorderFocusColor = Color.DimGray;
            txtCartao.BorderRadius = 4;
            txtCartao.BorderSize = 2;
            txtCartao.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Underline, GraphicsUnit.Point);
            txtCartao.ForeColor = Color.Gray;
            txtCartao.Location = new Point(67, 41);
            txtCartao.Margin = new Padding(0);
            txtCartao.Multiline = false;
            txtCartao.Name = "txtCartao";
            txtCartao.Padding = new Padding(10, 7, 10, 7);
            txtCartao.PasswordChar = false;
            txtCartao.PlaceholderColor = Color.DarkGray;
            txtCartao.PlaceholderText = "Ex: 0000 0000 0000 0000";
            txtCartao.RightToLeft = RightToLeft.No;
            txtCartao.Size = new Size(165, 29);
            txtCartao.TabIndex = 9;
            txtCartao.Texts = "";
            txtCartao.UnderlinedStyle = false;
            txtCartao._TextChanged += txtCartao__TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(painelDados);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(222, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 512);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint_1;
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(805, 578);
            Controls.Add(panel1);
            Name = "TelaPagamento";
            Text = "TelaPagamento";
            Load += TelaPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            painelDados.ResumeLayout(false);
            painelDados.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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