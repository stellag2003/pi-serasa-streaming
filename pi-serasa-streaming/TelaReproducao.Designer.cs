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
            this.btnAssistir = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.Black;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.ForeColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(407, 120);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(600, 400);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(407, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblNomefilme
            // 
            this.lblNomefilme.AutoSize = true;
            this.lblNomefilme.BackColor = System.Drawing.Color.Black;
            this.lblNomefilme.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomefilme.ForeColor = System.Drawing.Color.Red;
            this.lblNomefilme.Location = new System.Drawing.Point(12, 32);
            this.lblNomefilme.Name = "lblNomefilme";
            this.lblNomefilme.Size = new System.Drawing.Size(284, 50);
            this.lblNomefilme.TabIndex = 7;
            this.lblNomefilme.Text = "Nome do filme";
            // 
            // btnAssistir
            // 
            this.btnAssistir.BackColor = System.Drawing.Color.Black;
            this.btnAssistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssistir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssistir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAssistir.Location = new System.Drawing.Point(407, 563);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(99, 34);
            this.btnAssistir.TabIndex = 9;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = false;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Black;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescricao.Location = new System.Drawing.Point(22, 120);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(113, 30);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição:";
            // 
            // TelaReproducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1185, 728);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomefilme);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaReproducao";
            this.Text = "TelaReproducao";
            this.Load += new System.EventHandler(this.TelaReproducao_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private PictureBox pictureBox1;
        private Label lblNomefilme;
        private Button btnAssistir;
        private Label lblDescricao;
    }
}