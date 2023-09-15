namespace pi_serasa_streaming
{
    partial class Resenha
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
            panel1 = new Panel();
            iconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            btnComentar = new Button();
            label1 = new Label();
            txtComentario = new TextBox();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(iconPictureBox9);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnComentar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtComentario);
            panel1.Controls.Add(iconPictureBox5);
            panel1.Controls.Add(iconPictureBox4);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 577);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // iconPictureBox9
            // 
            iconPictureBox9.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox9.ForeColor = Color.Gray;
            iconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            iconPictureBox9.IconColor = Color.Gray;
            iconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox9.IconSize = 41;
            iconPictureBox9.Location = new Point(410, 111);
            iconPictureBox9.Name = "iconPictureBox9";
            iconPictureBox9.Size = new Size(41, 44);
            iconPictureBox9.TabIndex = 14;
            iconPictureBox9.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(410, 201);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 11;
            label4.Text = "Comentar";
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(108, 507);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(160, 23);
            btnComentar.TabIndex = 18;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(32, 395);
            label1.Name = "label1";
            label1.Size = new Size(146, 17);
            label1.TabIndex = 17;
            label1.Text = "Deixe seu comentário:";
            // 
            // txtComentario
            // 
            txtComentario.BackColor = SystemColors.ControlDark;
            txtComentario.Location = new Point(32, 420);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(304, 67);
            txtComentario.TabIndex = 16;
            txtComentario.TextChanged += txtComentario_TextChanged;
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox5.ForeColor = Color.Yellow;
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Star;
            iconPictureBox5.IconColor = Color.Yellow;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.Location = new Point(70, 324);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(32, 32);
            iconPictureBox5.TabIndex = 5;
            iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox4.ForeColor = Color.Yellow;
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Star;
            iconPictureBox4.IconColor = Color.Yellow;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.Location = new Point(32, 324);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(32, 32);
            iconPictureBox4.TabIndex = 4;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.ActiveCaptionText;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 192;
            iconPictureBox1.Location = new Point(32, 111);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(304, 192);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Location = new Point(518, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 10);
            panel2.TabIndex = 19;
            panel2.Paint += panel2_Paint;
            // 
            // Resenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1017, 602);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Resenha";
            Text = "Resenha";
            Load += Resenha_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox9;
        private Label label1;
        private TextBox txtComentario;
        private Button btnComentar;
        private Panel panel2;
    }
}