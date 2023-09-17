namespace pi_serasa_streaming
{
    partial class Resenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resenha));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            painel = new Panel();
            menu = new Panel();
            pictureBox2 = new PictureBox();
            tabelaTarefasUsuario = new DataGridView();
            tabelaTodaTarefas = new DataGridView();
            lblUser = new Label();
            label3 = new Label();
            label2 = new Label();
            btnComentar = new Button();
            label1 = new Label();
            txtComentario = new TextBox();
            pictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            painel.SuspendLayout();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaTarefasUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabelaTodaTarefas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // painel
            // 
            painel.BackColor = SystemColors.ActiveCaptionText;
            painel.Controls.Add(menu);
            painel.Controls.Add(tabelaTarefasUsuario);
            painel.Controls.Add(tabelaTodaTarefas);
            painel.Controls.Add(lblUser);
            painel.Controls.Add(label3);
            painel.Controls.Add(label2);
            painel.Controls.Add(btnComentar);
            painel.Controls.Add(label1);
            painel.Controls.Add(txtComentario);
            painel.Controls.Add(pictureBox1);
            painel.Location = new Point(10, 6);
            painel.Name = "painel";
            painel.Size = new Size(1214, 583);
            painel.TabIndex = 0;
            // 
            // menu
            // 
            menu.BackColor = Color.Black;
            menu.Controls.Add(pictureBox2);
            menu.Location = new Point(58, 28);
            menu.Name = "menu";
            menu.Size = new Size(382, 104);
            menu.TabIndex = 25;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // tabelaTarefasUsuario
            // 
            tabelaTarefasUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabelaTarefasUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabelaTarefasUsuario.BackgroundColor = Color.Black;
            tabelaTarefasUsuario.BorderStyle = BorderStyle.None;
            tabelaTarefasUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tabelaTarefasUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tabelaTarefasUsuario.ColumnHeadersHeight = 30;
            tabelaTarefasUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabelaTarefasUsuario.EnableHeadersVisualStyles = false;
            tabelaTarefasUsuario.GridColor = Color.Black;
            tabelaTarefasUsuario.Location = new Point(704, 412);
            tabelaTarefasUsuario.Name = "tabelaTarefasUsuario";
            tabelaTarefasUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tabelaTarefasUsuario.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Malgun Gothic Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            tabelaTarefasUsuario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            tabelaTarefasUsuario.RowTemplate.Height = 25;
            tabelaTarefasUsuario.Size = new Size(489, 168);
            tabelaTarefasUsuario.TabIndex = 24;
            tabelaTarefasUsuario.CellContentClick += tabelaTarefasUsuario_CellContentClick;
            // 
            // tabelaTodaTarefas
            // 
            tabelaTodaTarefas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tabelaTodaTarefas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tabelaTodaTarefas.BackgroundColor = Color.Black;
            tabelaTodaTarefas.BorderStyle = BorderStyle.None;
            tabelaTodaTarefas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tabelaTodaTarefas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tabelaTodaTarefas.ColumnHeadersHeight = 30;
            tabelaTodaTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tabelaTodaTarefas.EnableHeadersVisualStyles = false;
            tabelaTodaTarefas.GridColor = Color.Black;
            tabelaTodaTarefas.Location = new Point(704, 107);
            tabelaTodaTarefas.Name = "tabelaTodaTarefas";
            tabelaTodaTarefas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tabelaTodaTarefas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Malgun Gothic Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            tabelaTodaTarefas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            tabelaTodaTarefas.RowTemplate.Height = 25;
            tabelaTodaTarefas.Size = new Size(489, 168);
            tabelaTodaTarefas.TabIndex = 23;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Black;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblUser.ForeColor = SystemColors.Control;
            lblUser.Location = new Point(795, 396);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 22;
            lblUser.Text = "usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(704, 396);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 21;
            label3.Text = "Comentários de";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(704, 89);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 20;
            label2.Text = "Todos os comentrios:";
            // 
            // btnComentar
            // 
            btnComentar.BackColor = Color.FromArgb(192, 0, 0);
            btnComentar.FlatAppearance.BorderSize = 0;
            btnComentar.FlatStyle = FlatStyle.Flat;
            btnComentar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnComentar.ForeColor = Color.White;
            btnComentar.Location = new Point(3, 534);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(160, 30);
            btnComentar.TabIndex = 18;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = false;
            btnComentar.Click += btnComentar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(3, 420);
            label1.Name = "label1";
            label1.Size = new Size(153, 17);
            label1.TabIndex = 17;
            label1.Text = "Comente sobre o filme:";
            // 
            // txtComentario
            // 
            txtComentario.BackColor = SystemColors.ControlLight;
            txtComentario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtComentario.Location = new Point(3, 440);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(600, 67);
            txtComentario.TabIndex = 16;
            txtComentario.TextChanged += txtComentario_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.ForeColor = SystemColors.ControlText;
            pictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            pictureBox1.IconColor = SystemColors.ControlText;
            pictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pictureBox1.IconSize = 137;
            pictureBox1.Location = new Point(49, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 137);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Resenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1230, 602);
            Controls.Add(painel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Resenha";
            Text = "Resenha";
            Load += Resenha_Load;
            painel.ResumeLayout(false);
            painel.PerformLayout();
            menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaTarefasUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabelaTodaTarefas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel painel;
        private FontAwesome.Sharp.IconPictureBox pictureBox1;
        private Label label1;
        private TextBox txtComentario;
        private Button btnComentar;
        private Label label2;
        private Label lblUser;
        private Label label3;
        private DataGridView tabelaTodaTarefas;
        private DataGridView tabelaTarefasUsuario;
        private Panel menu;
        private PictureBox pictureBox2;
    }
}