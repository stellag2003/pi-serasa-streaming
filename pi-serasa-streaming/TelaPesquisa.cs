using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_serasa_streaming
{
    public partial class TelaPesquisa : Form
    {
        public TelaPesquisa()
        {
            InitializeComponent();
        }

        private void TelaPesquisa_Load(object sender, EventArgs e)
        {
            Reproducao reproducao = new Reproducao();
            Program.nomeFilme = reproducao.buscaTodosFilmes();

            ListaFilmes.Clear();
            for (int i = 0; i < Program.nomeFilme.Count; i++)
            {
                ListaFilmes.Items.Add(Program.nomeFilme[i].nome);

            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pesquisa__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void ListaFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
