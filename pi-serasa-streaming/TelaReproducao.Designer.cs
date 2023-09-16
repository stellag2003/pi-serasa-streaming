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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaReproducao));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox1 = new PictureBox();
            lblNomefilme = new Label();
            btnAssistir = new Button();
            lblDescricao = new Label();
            menu = new Panel();
            pictureBox2 = new PictureBox();
            painel = new Panel();
            painelND = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            painel.SuspendLayout();
            painelND.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.Black;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.ForeColor = Color.White;
            webView21.Location = new Point(277, 160);
            webView21.Name = "webView21";
            webView21.Size = new Size(826, 419);
            webView21.TabIndex = 5;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(277, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(826, 419);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblNomefilme
            // 
            lblNomefilme.AutoSize = true;
            lblNomefilme.BackColor = Color.Black;
            lblNomefilme.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomefilme.ForeColor = Color.White;
            lblNomefilme.Location = new Point(3, 0);
            lblNomefilme.Name = "lblNomefilme";
            lblNomefilme.Size = new Size(61, 32);
            lblNomefilme.TabIndex = 7;
            lblNomefilme.Text = "sara";
            // 
            // btnAssistir
            // 
            btnAssistir.BackColor = Color.Red;
            btnAssistir.FlatStyle = FlatStyle.Flat;
            btnAssistir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAssistir.ForeColor = SystemColors.ButtonHighlight;
            btnAssistir.Location = new Point(88, 422);
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
            lblDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.WhiteSmoke;
            lblDescricao.ImageAlign = ContentAlignment.MiddleLeft;
            lblDescricao.Location = new Point(4, 60);
            lblDescricao.MaximumSize = new Size(350, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(98, 25);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição:";
            // 
            // menu
            // 
            menu.BackColor = Color.Black;
            menu.Controls.Add(pictureBox2);
            menu.Location = new Point(407, 23);
            menu.Name = "menu";
            menu.Size = new Size(382, 121);
            menu.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // painel
            // 
            painel.BackColor = Color.Black;
            painel.Controls.Add(webView21);
            painel.Controls.Add(pictureBox1);
            painel.Controls.Add(menu);
            painel.Controls.Add(painelND);
            painel.Location = new Point(1, 2);
            painel.Name = "painel";
            painel.Size = new Size(1239, 720);
            painel.TabIndex = 12;
            // 
            // painelND
            // 
            painelND.Controls.Add(label2);
            painelND.Controls.Add(lblNomefilme);
            painelND.Controls.Add(btnAssistir);
            painelND.Controls.Add(lblDescricao);
            painelND.Location = new Point(11, 160);
            painelND.Name = "painelND";
            painelND.Size = new Size(200, 472);
            painelND.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(4, 43);
            label2.MaximumSize = new Size(350, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 11;
            label2.Text = "Sobre o filme:";
            // 
            // TelaReproducao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1245, 728);
            Controls.Add(painel);
            Name = "TelaReproducao";
            Text = "TelaReproducao";
            Load += TelaReproducao_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            painel.ResumeLayout(false);
            painelND.ResumeLayout(false);
            painelND.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
        private Label lblNomefilme;
        private Button btnAssistir;
        private Label lblDescricao;
        private Panel menu;
        private PictureBox pictureBox2;
        private Panel painel;
        private Panel painelND;
        private Label label2;
    }
}