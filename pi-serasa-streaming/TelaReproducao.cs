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
            //Reproducao filme = reproducao.BuscaFilmeNome("Cidade de Deus");
            Reproducao filme = reproducao.BuscaPorId(10);

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
            Reproducao filme = reproducao.BuscaPorId(10);
            //MessageBox.Show(filme.link_filme);
            webView21.Source = new Uri(filme.link_filme);

        }

        private void webView21_Click(object sender, EventArgs e)
        {
           

        }
    }
}
