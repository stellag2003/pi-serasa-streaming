using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace pi_serasa_streaming
{
    public partial class Principal : Form
    {
        List<Reproducao> reproducoes = new List<Reproducao>();

        public Principal()
        {
            InitializeComponent();
        }
        void CarregaForm(Form form)
        {
            form.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            panel1.Visible = true;
            form.Location = new Point(panel1.Width / 3 - form.Width / 3, panel1.Height / 3 - form.Height / 2);
            form.Show();

        }


        void renderizaInterface()
        {

            foreach (Reproducao reproducao in reproducoes)
            {

                PictureBox imagem = new PictureBox();
                imagem.LoadAsync(reproducao.link_imagem);
                imagem.SizeMode = PictureBoxSizeMode.Zoom;
                imagem.Size = new Size(200, 200);
                panel3.Controls.Add(imagem);
                imagem.Location = new Point(panel3.Width, panel3.Height);
                //imagem.Click imagem.id
            }

        }

        public void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void btnResenha_Click(object sender, EventArgs e)
        {
         

        }

        public void btnProducoes_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void iconPictureBox2_Click(object sender, EventArgs e)
        {
            string pesquisa = Pesquisa.Texts;

            string query = $"SELECT * FROM reproducao WHERE nome LIKE '{pesquisa}%';";
            CarregaForm(new TelaPesquisa());

            
        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Pesquisa__TextChanged(object sender, EventArgs e)
        {
            //Pesquisa.Texts.;
        }

        private void Pesquisa__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Principal_Load_1(object sender, EventArgs e)
        {
            Reproducao reproducao = new Reproducao();
            reproducoes = reproducao.buscaTodosFilmes();
            renderizaInterface();
        }

        private void btnResenha_Click_1(object sender, EventArgs e)
        {
            CarregaForm(new Resenha());
            btnResenha.BackColor = Color.Gray;
            btnProducoes.BackColor = Color.Black;
        }

        private void btnProducoes_Click_1(object sender, EventArgs e)
        {
            CarregaForm(new Principal());
            btnProducoes.BackColor = Color.Gray;
            btnResenha.BackColor = Color.Black;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
