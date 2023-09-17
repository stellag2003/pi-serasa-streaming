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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnPesquisar = new FontAwesome.Sharp.IconPictureBox();
            btnProducoes = new Button();
            Pesquisa = new WiLBiT.WiLBiTTextBox();
            btnResenha = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPesquisar).BeginInit();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lista = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.lista);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(18, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1183, 816);
            this.panel1.TabIndex = 10;
            // 
            // lista
            // 
            this.lista.Location = new System.Drawing.Point(947, 81);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(121, 97);
            this.lista.TabIndex = 10;
            this.lista.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(900, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 23);
            this.comboBox1.TabIndex = 9;
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
            pictureBox1.Location = new Point(22, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1025, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // painel
            // 
            painel.Controls.Add(iconPictureBox1);
            painel.Controls.Add(panel1);
            painel.Controls.Add(btnPesquisar);
            painel.Controls.Add(btnProducoes);
            painel.Controls.Add(Pesquisa);
            painel.Controls.Add(btnResenha);
            painel.Location = new Point(26, 117);
            painel.Name = "painel";
            painel.Size = new Size(1288, 783);
            painel.TabIndex = 0;
            painel.Paint += painel_Paint_1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.ForeColor = Color.Gray;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.Gray;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 28;
            iconPictureBox1.Location = new Point(1132, 23);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(29, 28);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = SystemColors.ActiveCaptionText;
            btnPesquisar.BorderStyle = BorderStyle.FixedSingle;
            btnPesquisar.ForeColor = Color.Gray;
            btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            btnPesquisar.IconColor = Color.Gray;
            btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPesquisar.IconSize = 27;
            btnPesquisar.Location = new Point(941, 24);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(27, 27);
            btnPesquisar.SizeMode = PictureBoxSizeMode.Zoom;
            btnPesquisar.TabIndex = 5;
            btnPesquisar.TabStop = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnProducoes
            // 
            btnProducoes.BackColor = SystemColors.ActiveCaptionText;
            btnProducoes.FlatAppearance.BorderColor = Color.Black;
            btnProducoes.FlatAppearance.BorderSize = 0;
            btnProducoes.FlatStyle = FlatStyle.Flat;
            btnProducoes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProducoes.ForeColor = Color.White;
            btnProducoes.Location = new Point(311, 15);
            btnProducoes.Name = "btnProducoes";
            btnProducoes.Size = new Size(111, 36);
            btnProducoes.TabIndex = 1;
            btnProducoes.Text = "Produções";
            btnProducoes.UseVisualStyleBackColor = false;
            btnProducoes.Click += btnProducoes_Click_1;
            // 
            // Pesquisa
            // 
            Pesquisa.AccessibleRole = AccessibleRole.Grip;
            Pesquisa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Pesquisa.BackColor = Color.Black;
            Pesquisa.BorderColor = Color.Black;
            Pesquisa.BorderFocusColor = Color.DimGray;
            Pesquisa.BorderRadius = 4;
            Pesquisa.BorderSize = 2;
            Pesquisa.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            Pesquisa.ForeColor = Color.Gray;
            Pesquisa.Location = new Point(965, 22);
            Pesquisa.Margin = new Padding(4);
            Pesquisa.Multiline = false;
            Pesquisa.Name = "Pesquisa";
            Pesquisa.Padding = new Padding(10, 7, 10, 7);
            Pesquisa.PasswordChar = false;
            Pesquisa.PlaceholderColor = Color.DarkGray;
            Pesquisa.PlaceholderText = "Filmes, Séries, Atores...";
            Pesquisa.Size = new Size(160, 29);
            Pesquisa.TabIndex = 3;
            Pesquisa.Texts = "";
            Pesquisa.UnderlinedStyle = false;
            Pesquisa._TextChanged += Pesquisa__TextChanged_1;
            // 
            // btnResenha
            // 
            btnResenha.BackColor = SystemColors.ActiveCaptionText;
            btnResenha.FlatAppearance.BorderColor = Color.Black;
            btnResenha.FlatAppearance.BorderSize = 0;
            btnResenha.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnResenha.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnResenha.FlatStyle = FlatStyle.Flat;
            btnResenha.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResenha.ForeColor = Color.White;
            btnResenha.Location = new Point(441, 15);
            btnResenha.Name = "btnResenha";
            btnResenha.Size = new Size(111, 36);
            btnResenha.TabIndex = 2;
            btnResenha.Text = "Resenhas";
            btnResenha.UseVisualStyleBackColor = false;
            btnResenha.Click += btnResenha_Click_1;
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
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPesquisar).EndInit();
            ResumeLayout(false);
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
        private ComboBox comboBox1;
        private ListView lista;
    }
}