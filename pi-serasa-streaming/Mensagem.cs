using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pi_serasa_streaming
{

    public partial class Mensagem : Form
    {
        public Mensagem()
        {
            InitializeComponent();
        }

        private void Mensagem_Load(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            Program.u = usuario.buscaTodos();

            lista.Clear();
            for (int i = 0; i < Program.u.Count; i++)
            {
                lista.Items.Add(Program.u[i].nome);
            }

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaU telaU = new TelaU();
            telaU.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lista_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
