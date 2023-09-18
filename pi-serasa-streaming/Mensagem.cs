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
    //List<Usuario>  = new List<Usuario>();
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
           // usuario.carregaDados();
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
