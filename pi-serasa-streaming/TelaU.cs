using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_serasa_streaming
{
    public partial class TelaU : Form
    {
        public TelaU()
        {
            InitializeComponent();
        }

        private void TelaU_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painelU.Location = new Point(ClientSize.Width / 2 - painelU.Size.Width / 2, ClientSize.Height / 2 - painelU.Height / 2);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
                string usuario;
                string senha;

                usuario = txtEmail.Text;
                senha = txtSenha.Text;

            
            
           
        }
    }
}
