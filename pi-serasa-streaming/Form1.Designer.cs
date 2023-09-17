namespace pi_serasa_streaming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            label3 = new Label();
            panel8 = new Panel();
            label4 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            panel13 = new Panel();
            btnResenha = new Button();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            button1 = new Button();
            wilBitTextBox1 = new WiLBiT.WiLBiTTextBox();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panel14 = new Panel();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            wilBitPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(21, 277);
            panel3.Name = "panel3";
            panel3.Size = new Size(902, 141);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, -2);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 4;
            label3.Text = "Mais assistidos";
            // 
            // panel8
            // 
            panel8.AutoScroll = true;
            panel8.Controls.Add(label4);
            panel8.Location = new Point(22, 446);
            panel8.Name = "panel8";
            panel8.Size = new Size(901, 141);
            panel8.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, -3);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 5;
            label4.Text = "Recomendados";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.ForeColor = SystemColors.AppWorkspace;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.AppWorkspace;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 28;
            iconPictureBox1.Location = new Point(932, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(31, 28);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(panel13);
            panel2.Controls.Add(btnResenha);
            panel2.Controls.Add(iconPictureBox2);
            panel2.Controls.Add(wilBitPanel1);
            panel2.Controls.Add(wilBitTextBox1);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Location = new Point(12, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(954, 591);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel13
            // 
            panel13.Location = new Point(25, 36);
            panel13.Name = "panel13";
            panel13.Size = new Size(942, 570);
            panel13.TabIndex = 5;
            // 
            // btnResenha
            // 
            btnResenha.BackColor = SystemColors.ActiveCaptionText;
            btnResenha.FlatAppearance.BorderColor = Color.Black;
            btnResenha.FlatAppearance.BorderSize = 0;
            btnResenha.ForeColor = Color.White;
            btnResenha.Location = new Point(457, -3);
            btnResenha.Name = "btnResenha";
            btnResenha.Size = new Size(111, 36);
            btnResenha.TabIndex = 1;
            btnResenha.Text = "Resenhas";
            btnResenha.UseVisualStyleBackColor = false;
            btnResenha.Click += btnResenha_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox2.BorderStyle = BorderStyle.FixedSingle;
            iconPictureBox2.ForeColor = Color.Gray;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            iconPictureBox2.IconColor = Color.Gray;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 27;
            iconPictureBox2.Location = new Point(894, 3);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(27, 27);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox2.TabIndex = 4;
            iconPictureBox2.TabStop = false;
            // 
            // wilBitPanel1
            // 
            wilBitPanel1.BackColor = SystemColors.ActiveCaptionText;
            wilBitPanel1.BorderColor = Color.Peru;
            wilBitPanel1.BorderRadius = 6;
            wilBitPanel1.BorderSize = 0;
            wilBitPanel1.Controls.Add(button1);
            wilBitPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            wilBitPanel1.ForeColor = Color.RosyBrown;
            wilBitPanel1.Location = new Point(283, -7);
            wilBitPanel1.Name = "wilBitPanel1";
            wilBitPanel1.Size = new Size(168, 46);
            wilBitPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 7);
            button1.Name = "button1";
            button1.Size = new Size(111, 36);
            button1.TabIndex = 0;
            button1.Text = "Produções";
            button1.UseVisualStyleBackColor = false;
            // 
            // wilBitTextBox1
            // 
            wilBitTextBox1.BackColor = Color.Black;
            wilBitTextBox1.BorderColor = Color.DimGray;
            wilBitTextBox1.BorderFocusColor = Color.DimGray;
            wilBitTextBox1.BorderRadius = 4;
            wilBitTextBox1.BorderSize = 2;
            wilBitTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            wilBitTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            wilBitTextBox1.Location = new Point(750, 1);
            wilBitTextBox1.Margin = new Padding(4);
            wilBitTextBox1.Multiline = false;
            wilBitTextBox1.Name = "wilBitTextBox1";
            wilBitTextBox1.Padding = new Padding(10, 7, 10, 7);
            wilBitTextBox1.PasswordChar = false;
            wilBitTextBox1.PlaceholderColor = Color.DarkGray;
            wilBitTextBox1.PlaceholderText = "";
            wilBitTextBox1.Size = new Size(160, 29);
            wilBitTextBox1.TabIndex = 1;
            wilBitTextBox1.Texts = "";
            wilBitTextBox1.UnderlinedStyle = false;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // panel14
            // 
            panel14.Location = new Point(1040, 155);
            panel14.Name = "panel14";
            panel14.Size = new Size(200, 100);
            panel14.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1330, 467);
            Controls.Add(panel14);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            wilBitPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private WiLBiT.WiLBiTTextBox wilBitTextBox1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Button btnResenha;
        private Button button1;
        private Panel panel13;
        private Panel panel14;
    }
}