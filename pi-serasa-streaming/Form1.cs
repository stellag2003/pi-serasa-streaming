namespace pi_serasa_streaming
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        void CarregaForm(Form form)
        {
            form.TopLevel = false;
            panel14.Controls.Clear();
            panel14.Controls.Add(form);
            form.Location = new Point(panel14.Width / 2 - form.Width / 2, panel14.Height / 2 - form.Height / 2);
            form.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void açãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //filmes.Clear();
            //for (int i = 0; i < filmes.Count; i++)
            // {
            // filmes.Add(filmes[i]);
            // }

            WindowState = FormWindowState.Maximized;
            panel13.Location = new Point(ClientSize.Width / 2 - panel13.Size.Width / 2, ClientSize.Height / 2 - panel13.Size.Height / 2);


        }

        private void lblResenha_Click(object sender, EventArgs e)
        {

        }

        private void btnResenha_Click(object sender, EventArgs e)
        {

            CarregaForm(new Resenha());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}