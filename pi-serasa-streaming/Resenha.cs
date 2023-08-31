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
    public partial class Resenha : Form
    {
        public Resenha()
        {
            InitializeComponent();
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2 , ClientSize.Height / 2 - panel1.Size.Height / 2);
        }
    }
}
