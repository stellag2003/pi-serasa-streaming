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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNomefilme = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAssistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(617, 224);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(182, 86);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(147, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNomefilme
            // 
            this.lblNomefilme.AutoSize = true;
            this.lblNomefilme.BackColor = System.Drawing.Color.Transparent;
            this.lblNomefilme.Location = new System.Drawing.Point(183, 224);
            this.lblNomefilme.Name = "lblNomefilme";
            this.lblNomefilme.Size = new System.Drawing.Size(87, 15);
            this.lblNomefilme.TabIndex = 7;
            this.lblNomefilme.Text = "Nome do filme";
            this.lblNomefilme.Click += new System.EventHandler(this.lblNomefilme_Click_1);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Location = new System.Drawing.Point(183, 266);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnAssistir
            // 
            this.btnAssistir.BackColor = System.Drawing.Color.Transparent;
            this.btnAssistir.Location = new System.Drawing.Point(183, 307);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(75, 23);
            this.btnAssistir.TabIndex = 9;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = false;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // TelaReproducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1061, 613);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.lblNomefilme);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaReproducao";
            this.Text = "TelaReproducao";
            this.Load += new System.EventHandler(this.TelaReproducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
        private Label lblNomefilme;
        private Label lblDescricao;
        private Button btnAssistir;
    }
}