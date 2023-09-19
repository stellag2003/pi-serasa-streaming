namespace pi_serasa_streaming
{
    partial class Mensagem
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
            btnVoltar = new WiLBiT.WiLBiTButton();
            btnSair = new WiLBiT.WiLBiTButton();
            panel1 = new Panel();
            lista = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.DimGray;
            btnVoltar.BorderColor = Color.FromArgb(72, 116, 245);
            btnVoltar.BorderRadius = 6;
            btnVoltar.BorderSize = 0;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(21, 167);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 28);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += wilBitButton1_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.DimGray;
            btnSair.BorderColor = Color.FromArgb(72, 116, 245);
            btnSair.BorderRadius = 6;
            btnSair.BorderSize = 0;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.ForeColor = Color.White;
            btnSair.Location = new Point(127, 167);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 28);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair da conta";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lista);
            panel1.Location = new Point(5, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 198);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // lista
            // 
            lista.BackColor = SystemColors.InfoText;
            lista.ForeColor = SystemColors.InactiveBorder;
            lista.Location = new Point(16, 24);
            lista.Name = "lista";
            lista.Size = new Size(206, 106);
            lista.TabIndex = 0;
            lista.UseCompatibleStateImageBehavior = false;
            lista.View = View.List;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged_1;
            // 
            // Mensagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(255, 222);
            Controls.Add(btnSair);
            Controls.Add(btnVoltar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mensagem";
            Text = "Mensagem";
            Load += Mensagem_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTButton btnVoltar;
        private WiLBiT.WiLBiTButton btnSair;
        private Panel panel1;
        private ListView lista;
    }
}