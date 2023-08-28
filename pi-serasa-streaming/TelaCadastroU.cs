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
    public partial class TelaCadastroU : Form
    {
        public TelaCadastroU()
        {
            InitializeComponent();
        }

        private void TelaCadastroU_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painelCadastro.Location = new Point(ClientSize.Width / 2 - painelCadastro.Size.Width / 2, ClientSize.Height / 2 - painelCadastro.Height / 2);
        }
    }
}
