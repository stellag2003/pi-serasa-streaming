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


            Reproducao reproducao = new Reproducao();

            Reproducao filme = reproducao.BuscaPorId(10);

            WindowState = FormWindowState.Maximized;
         
            pictureBox1.Size = new Size( ClientSize.Width , ClientSize.Height );

            pictureBox1.Dock = DockStyle.Fill;



            lblNomefilme.Visible = true;
            lblDescricao.Visible = true;
            lblDescricao.Size = new Size(ClientSize.Width, ClientSize.Height);
            pictureBox1.Visible = true;


            lblNomefilme.Text = filme.nome;
            lblDescricao.Text = filme.descricao;
            pictureBox1.LoadAsync(filme.link_assistir);
            


        }

        private void lblNomeFilme_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {
            Reproducao reproducao = new Reproducao();
            Reproducao filme = reproducao.BuscaPorId(10);
            //MessageBox.Show(filme.link_filme);
            webView21.Source = new Uri(filme.link_filme);
            webView21.Dock = DockStyle.Fill;

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
    }
}
