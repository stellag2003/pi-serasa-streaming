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

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();
            usuario.BuscaPorId(2);

            for (int i = 0; i < Program.u.Count; i++)
            {
                lista.Items.Add(Program.u[i].nome);
            }
            lista.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Principal principal = new Principal();
            //principal.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
