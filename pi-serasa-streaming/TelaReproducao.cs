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
    public partial class TelaReproducao : Form
    {
        public TelaReproducao()
        {
            InitializeComponent();
        }

        private void TelaReproducao_Load(object sender, EventArgs e)
        {
            Reproducao reproducao = new Reproducao();

        }
    }
}
