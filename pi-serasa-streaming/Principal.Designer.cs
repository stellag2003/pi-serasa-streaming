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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painel = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnPesquisar = new FontAwesome.Sharp.IconPictureBox();
            this.btnProducoes = new System.Windows.Forms.Button();
            this.Pesquisa = new WiLBiT.WiLBiTTextBox();
            this.btnResenha = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 816);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(22, 235);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(1096, 427);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mais assistidos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1025, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // painel
            // 
            this.painel.Controls.Add(this.iconPictureBox1);
            this.painel.Controls.Add(this.panel1);
            this.painel.Controls.Add(this.btnPesquisar);
            this.painel.Controls.Add(this.btnProducoes);
            this.painel.Controls.Add(this.Pesquisa);
            this.painel.Controls.Add(this.btnResenha);
            this.painel.Location = new System.Drawing.Point(26, 117);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(1288, 783);
            this.painel.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Location = new System.Drawing.Point(1132, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 28);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnPesquisar.IconColor = System.Drawing.Color.Gray;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 27;
            this.btnPesquisar.Location = new System.Drawing.Point(941, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(27, 27);
            this.btnPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.TabStop = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnProducoes
            // 
            this.btnProducoes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProducoes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProducoes.FlatAppearance.BorderSize = 0;
            this.btnProducoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducoes.ForeColor = System.Drawing.Color.White;
            this.btnProducoes.Location = new System.Drawing.Point(311, 15);
            this.btnProducoes.Name = "btnProducoes";
            this.btnProducoes.Size = new System.Drawing.Size(111, 36);
            this.btnProducoes.TabIndex = 1;
            this.btnProducoes.Text = "Produções";
            this.btnProducoes.UseVisualStyleBackColor = false;
            this.btnProducoes.Click += new System.EventHandler(this.btnProducoes_Click_1);
            // 
            // Pesquisa
            // 
            this.Pesquisa.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.Pesquisa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Pesquisa.BackColor = System.Drawing.Color.Black;
            this.Pesquisa.BorderColor = System.Drawing.Color.Black;
            this.Pesquisa.BorderFocusColor = System.Drawing.Color.DimGray;
            this.Pesquisa.BorderRadius = 4;
            this.Pesquisa.BorderSize = 2;
            this.Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pesquisa.ForeColor = System.Drawing.Color.Gray;
            this.Pesquisa.Location = new System.Drawing.Point(965, 22);
            this.Pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.Pesquisa.Multiline = false;
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Pesquisa.PasswordChar = false;
            this.Pesquisa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Pesquisa.PlaceholderText = "Filmes, Séries, Atores...";
            this.Pesquisa.Size = new System.Drawing.Size(160, 29);
            this.Pesquisa.TabIndex = 3;
            this.Pesquisa.Texts = "";
            this.Pesquisa.UnderlinedStyle = false;
            this.Pesquisa._TextChanged += new System.EventHandler(this.Pesquisa__TextChanged_1);
            // 
            // btnResenha
            // 
            this.btnResenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResenha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResenha.FlatAppearance.BorderSize = 0;
            this.btnResenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnResenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResenha.ForeColor = System.Drawing.Color.White;
            this.btnResenha.Location = new System.Drawing.Point(441, 15);
            this.btnResenha.Name = "btnResenha";
            this.btnResenha.Size = new System.Drawing.Size(111, 36);
            this.btnResenha.TabIndex = 2;
            this.btnResenha.Text = "Resenhas";
            this.btnResenha.UseVisualStyleBackColor = false;
            this.btnResenha.Click += new System.EventHandler(this.btnResenha_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1361, 749);
            this.Controls.Add(this.painel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel painel;
        public Panel panel3;
        private WiLBiT.WiLBiTTextBox Pesquisa;
        private FontAwesome.Sharp.IconPictureBox btnPesquisar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button btnProducoes;
        private Button btnResenha;
    }
}