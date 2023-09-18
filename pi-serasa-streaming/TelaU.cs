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
            this.BackColor = Color.White;
            painelU.BackColor = Color.FromArgb(200, Color.Black);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);
        }


        private void TelaU_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painelU.Location = new Point(
            this.ClientSize.Width / 2 - painelU.Size.Width / 2,
            this.ClientSize.Height / 2 - painelU.Size.Height / 2);
            painelU.Anchor = AnchorStyles.None;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario = txtEmail.Text;
            senha = txtSenha.Text;

            Usuario u = new Usuario();
            u = u.Login(usuario, senha);


            if (u == null)
            {
                MessageBox.Show("Login inválido");
                return;
            }

            Program.usuario = u;

            Principal usuarioPrincipal = new Principal();
            usuarioPrincipal.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            TelaCadastroU telaCadastro = new TelaCadastroU();
            telaCadastro.Show();
        }

        private void painelU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
