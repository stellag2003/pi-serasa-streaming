namespace pi_serasa_streaming
{
    partial class TelaPesquisa
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
            ListaFilmes = new ListView();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ListaFilmes);
            panel1.Location = new Point(22, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 468);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ListaFilmes
            // 
            ListaFilmes.BackColor = SystemColors.InfoText;
            ListaFilmes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ListaFilmes.ForeColor = Color.Linen;
            ListaFilmes.Location = new Point(32, 24);
            ListaFilmes.Name = "ListaFilmes";
            ListaFilmes.Size = new Size(831, 411);
            ListaFilmes.TabIndex = 0;
            ListaFilmes.UseCompatibleStateImageBehavior = false;
            ListaFilmes.View = View.Tile;
            ListaFilmes.SelectedIndexChanged += ListaFilmes_SelectedIndexChanged;
            // 
            // TelaPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(971, 637);
            Controls.Add(panel1);
            Name = "TelaPesquisa";
            Text = "TelaPesquisa";
            Load += TelaPesquisa_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListView ListaFilmes;
    }
}