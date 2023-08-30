namespace pi_serasa_streaming
{
    public partial class Form1 : Form
    {
    
        List<string> filmes = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        void geraForm(string filmes)
        {
            Panel panel = new Panel();
            panel.Name = "panel";
            panel.BackColor = Color.AliceBlue;
            panel.Size = new Size(100, 100);

            Label label = new Label();
            // label.name =...
            label.Text = filmes;
            label.AutoSize = true;
            label.Location = new Point(0, 0);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void açãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmes.Clear();
            for (int i = 0; i < filmes.Count; i++)
            {
                filmes.Add(filmes[i]);
            }

            Resenha resenha = new Resenha();
            resenha.TopLevel = false;
            panel1.Controls.Add(resenha);
            resenha.Show();
            resenha.Location = new Point(0, 0);

            geraForm();


        }

        private void lblResenha_Click(object sender, EventArgs e)
        {
            
        }

        private void btnResenha_Click(object sender, EventArgs e)
        {
            
        }
    }
}