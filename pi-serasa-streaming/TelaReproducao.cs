using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


            Reproducao reproducao= new Reproducao();

            Reproducao filme = reproducao.BuscaPorId(5);

            WindowState = FormWindowState.Maximized;
            pictureBox1.Location = new Point(ClientSize.Width / 2 - pictureBox1.Size.Width / 2, ClientSize.Height / 2 - pictureBox1.Height / 2);

            WindowState = FormWindowState.Maximized;
            webView21.Location = new Point(ClientSize.Width / 2 - webView21.Size.Width / 2, ClientSize.Height / 2 - webView21.Height / 2);

            // ---------------------------------------------------

           

            lblNomefilme.Visible = true;
            lblDescricao.Visible = true;
            pictureBox1.Visible = true;


            lblNomefilme.Text = filme.nome;
            lblDescricao.Text = filme.descricao;
            pictureBox1.LoadAsync(filme.link_imagem);

            



        }

        private void lblNomeFilme_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            Reproducao reproducao= new Reproducao();
            Reproducao filme = reproducao.BuscaPorId(5);
            //MessageBox.Show(filme.link_filme);
            webView21.Source = new Uri(filme.link_filme);
            webView21.Dock = DockStyle.Fill;

        }

        private void webView21_Click(object sender, EventArgs e)
        {
           

        }
    }
}
