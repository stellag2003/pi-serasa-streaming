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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomefilme = new System.Windows.Forms.Label();
            this.btnAssistir = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.painel = new System.Windows.Forms.Panel();
            this.painelND = new System.Windows.Forms.Panel();
            this.btnComentar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.painel.SuspendLayout();
            this.painelND.SuspendLayout();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.Black;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.ForeColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(277, 160);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(826, 419);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(277, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(826, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomefilme
            // 
            this.lblNomefilme.AutoSize = true;
            this.lblNomefilme.BackColor = System.Drawing.Color.Black;
            this.lblNomefilme.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomefilme.ForeColor = System.Drawing.Color.White;
            this.lblNomefilme.Location = new System.Drawing.Point(3, 0);
            this.lblNomefilme.Name = "lblNomefilme";
            this.lblNomefilme.Size = new System.Drawing.Size(61, 32);
            this.lblNomefilme.TabIndex = 7;
            this.lblNomefilme.Text = "sara";
            // 
            // btnAssistir
            // 
            this.btnAssistir.BackColor = System.Drawing.Color.Red;
            this.btnAssistir.FlatAppearance.BorderSize = 0;
            this.btnAssistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAssistir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAssistir.Location = new System.Drawing.Point(4, 425);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(99, 34);
            this.btnAssistir.TabIndex = 9;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = false;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click_);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Black;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescricao.Location = new System.Drawing.Point(4, 60);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(98, 25);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição:";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Black;
            this.menu.Controls.Add(this.pictureBox2);
            this.menu.Location = new System.Drawing.Point(407, 23);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(382, 121);
            this.menu.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // painel
            // 
            this.painel.BackColor = System.Drawing.Color.Black;
            this.painel.Controls.Add(this.webView21);
            this.painel.Controls.Add(this.pictureBox1);
            this.painel.Controls.Add(this.menu);
            this.painel.Controls.Add(this.painelND);
            this.painel.Location = new System.Drawing.Point(1, 2);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(1239, 720);
            this.painel.TabIndex = 12;
            this.painel.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_Paint_1);
            // 
            // painelND
            // 
            this.painelND.Controls.Add(this.btnComentar);
            this.painelND.Controls.Add(this.label2);
            this.painelND.Controls.Add(this.lblNomefilme);
            this.painelND.Controls.Add(this.btnAssistir);
            this.painelND.Controls.Add(this.lblDescricao);
            this.painelND.Location = new System.Drawing.Point(11, 160);
            this.painelND.Name = "painelND";
            this.painelND.Size = new System.Drawing.Size(237, 472);
            this.painelND.TabIndex = 12;
            this.painelND.Paint += new System.Windows.Forms.PaintEventHandler(this.painelND_Paint);
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnComentar.FlatAppearance.BorderSize = 0;
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComentar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComentar.Location = new System.Drawing.Point(109, 425);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(99, 34);
            this.btnComentar.TabIndex = 12;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(4, 43);
            this.label2.MaximumSize = new System.Drawing.Size(350, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sobre o filme:";
            // 
            // TelaReproducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1245, 728);
            this.Controls.Add(this.painel);
            this.Name = "TelaReproducao";
            this.Text = "TelaReproducao";
            this.Load += new System.EventHandler(this.TelaReproducao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.painel.ResumeLayout(false);
            this.painelND.ResumeLayout(false);
            this.painelND.PerformLayout();
            this.ResumeLayout(false);

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
        private Button btnComentar;
    }
}