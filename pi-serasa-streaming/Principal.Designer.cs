namespace pi_serasa_streaming
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            painel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(18, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 816);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(22, 235);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(1096, 427);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1074, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // painel
            // 
            painel.Controls.Add(panel1);
            painel.Location = new Point(26, 117);
            painel.Name = "painel";
            painel.Size = new Size(1288, 783);
            painel.TabIndex = 0;
            painel.Paint += painel_Paint_1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1361, 749);
            Controls.Add(painel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load_1;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            painel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel painel;
        public Panel panel3;
    }
}