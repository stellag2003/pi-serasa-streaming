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
            painel.Controls.Clear();
            painel.Controls.Add(form);
            //panel1.Visible = true;
            form.Location = new Point(panel1.Width / 3 - form.Width / 3, panel1.Height / 3 - form.Height / 2);
            form.Show();

        }


        void renderizaInterface()
        {

            // alterar aqui quantos filmes por linha
            int fixo_por_linha = 10;

            int quantidade_linha = fixo_por_linha;
            int altura_linha = 0;
            int numero_linha = 0;
            int tamanho_imagem = 200;
            int margem = 10;

            for (int i = 0; i < reproducoes.Count; i++)
            {
                Reproducao reproducao = reproducoes[i];
                PictureBox imagem = new PictureBox();
                imagem.LoadAsync(reproducao.link_imagem);
                imagem.SizeMode = PictureBoxSizeMode.Zoom;
                imagem.Size = new Size(190, 200);
                panel3.Controls.Add(imagem);

                imagem.MouseClick += new MouseEventHandler((o,a) => Program.filmeClicado(reproducao));

                if( quantidade_linha == i)
                {
                    quantidade_linha *= 2;
                    altura_linha += tamanho_imagem;
                }

                if(numero_linha > fixo_por_linha - 1)
                {
                    numero_linha = 0;
                }
                int posicao_imagem = tamanho_imagem * numero_linha + margem;
                numero_linha++;

                imagem.Location = new Point(posicao_imagem + margem, altura_linha);

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
           // Pesquisa.Texts.;
        }

        private void Pesquisa__TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Principal_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painel.Location = new Point(ClientSize.Width / 2 - painel.Size.Width / 2 , ClientSize.Height / 2 - painel.Height / 2);


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
