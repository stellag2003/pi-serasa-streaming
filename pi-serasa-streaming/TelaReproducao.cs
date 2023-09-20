using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace pi_serasa_streaming
{
    public partial class TelaReproducao : Form
    {

        public TelaReproducao()
        {
            InitializeComponent();

        }

        private void TelaReproducao_Load(object sender, EventArgs e)
        {


            //Reproducao reproducao = new Reproducao();

            //Reproducao filme = reproducao.BuscaPorId(10);

            
        }

        private void lblNomeFilme_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
           

        }

        private void webView21_Click(object sender, EventArgs e)
        {


        }

        private void lblNomefilme_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void webView21_Click_1(object sender, EventArgs e)
        {

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            
        }

        private void painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void TelaReproducao_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painel.Location = new Point(ClientSize.Width / 2 - painel.Size.Width / 2 + 40, ClientSize.Height / 2 - painel.Height / 2 + 50);
            menu.Location = new Point(400, -30);
            menu.Size = new Size(ClientSize.Width, 100);

            pictureBox1.Location = new Point(400, 100);
            pictureBox1.Size = new Size(860, 500);

            painelND.Location = new Point(0, 100);
            painelND.Size = new Size(ClientSize.Width, 550);
            // pictureBox1.Dock = DockStyle.Fill;



            lblNomefilme.Visible = true;
            lblDescricao.Visible = true;
            lblDescricao.Size = new Size(ClientSize.Width, ClientSize.Height);
            pictureBox1.Visible = true;

            lblNomefilme.Text = Program.reproducao.nome;
            lblDescricao.Text = Program.reproducao.descricao;
            pictureBox1.LoadAsync(Program.reproducao.link_assistir);
        }

        private void webView21_Click_2(object sender, EventArgs e)
        {

        }

        private void btnAssistir_Click_(object sender, EventArgs e)
        {
            Reproducao reproducao = new Reproducao();
            Reproducao filme = reproducao.BuscaPorId(Program.reproducao.id);
            //MessageBox.Show(filme.link_filme);
            webView21.Source = new Uri(filme.link_filme);
            webView21.Dock = DockStyle.Fill;
        }

        private void btnComentar_Click_1(object sender, EventArgs e)
        {
            Resenha resenha = new Resenha();
            resenha.Show();
        }

        private void painelND_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
