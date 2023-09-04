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
            this.lblNomeFilme = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnAssistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeFilme
            // 
            this.lblNomeFilme.AutoSize = true;
            this.lblNomeFilme.Location = new System.Drawing.Point(76, 217);
            this.lblNomeFilme.Name = "lblNomeFilme";
            this.lblNomeFilme.Size = new System.Drawing.Size(127, 15);
            this.lblNomeFilme.TabIndex = 0;
            this.lblNomeFilme.Text = "Auto Da Compadecida";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(76, 254);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 15);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // btnAssistir
            // 
            this.btnAssistir.Location = new System.Drawing.Point(108, 300);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(75, 23);
            this.btnAssistir.TabIndex = 2;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = true;
            // 
            // TelaReproducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pi_serasa_streaming.Properties.Resources.auto_da_compadecida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeFilme);
            this.Name = "TelaReproducao";
            this.Text = "TelaReproducao";
            this.Load += new System.EventHandler(this.TelaReproducao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeFilme;
        private Label lblDescricao;
        private Button btnAssistir;
    }
}