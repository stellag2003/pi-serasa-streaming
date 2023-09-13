namespace pi_serasa_streaming
{
    partial class TelaReproducao
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox1 = new PictureBox();
            lblNomefilme = new Label();
            btnAssistir = new Button();
            lblDescricao = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.Black;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.ForeColor = Color.White;
            webView21.Location = new Point(407, 120);
            webView21.Name = "webView21";
            webView21.Size = new Size(600, 400);
            webView21.TabIndex = 5;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(407, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblNomefilme
            // 
            lblNomefilme.AutoSize = true;
            lblNomefilme.BackColor = Color.Black;
            lblNomefilme.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomefilme.ForeColor = Color.Red;
            lblNomefilme.Location = new Point(12, 32);
            lblNomefilme.Name = "lblNomefilme";
            lblNomefilme.Size = new Size(284, 50);
            lblNomefilme.TabIndex = 7;
            lblNomefilme.Text = "Nome do filme";
            lblNomefilme.Click += lblNomefilme_Click_1;
            // 
            // btnAssistir
            // 
            btnAssistir.BackColor = Color.Black;
            btnAssistir.FlatStyle = FlatStyle.Flat;
            btnAssistir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssistir.ForeColor = SystemColors.ButtonHighlight;
            btnAssistir.Location = new Point(407, 566);
            btnAssistir.Name = "btnAssistir";
            btnAssistir.Size = new Size(99, 34);
            btnAssistir.TabIndex = 9;
            btnAssistir.Text = "Assistir";
            btnAssistir.UseVisualStyleBackColor = false;
            btnAssistir.Click += btnAssistir_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.BackColor = Color.Black;
            lblDescricao.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.ImageAlign = ContentAlignment.MiddleLeft;
            lblDescricao.Location = new Point(22, 120);
            lblDescricao.MaximumSize = new Size(350, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(113, 30);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição:";
            // 
            // TelaReproducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1061, 728);
            Controls.Add(lblDescricao);
            Controls.Add(lblNomefilme);
            Controls.Add(btnAssistir);
            Controls.Add(webView21);
            Controls.Add(pictureBox1);
            Name = "TelaReproducao";
            Text = "TelaReproducao";
            Load += TelaReproducao_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
        private Label lblNomefilme;
        private Button btnAssistir;
        private Label lblDescricao;
    }
}