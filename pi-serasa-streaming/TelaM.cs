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
    public partial class TelaM : Form
    {
        public TelaM()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario = txtUsuario.Text;
            senha = txtPassaword.Text;

            if (usuario == "admim" && senha == "566332")
            {
                MessageBox.Show(" Acesso autorizado! ");
            }
            else
            {
                MessageBox.Show(" Usuário ou senha incorreto!");
            }
        }

        private void TelaM_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painelM.Location = new Point(ClientSize.Width / 2 - painelM.Size.Width / 2, ClientSize.Height / 2 - painelM.Height / 2);
        }
    }
}
