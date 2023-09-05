using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace pi_serasa_streaming
{
    public partial class Principal : Form
    {

        List <Reproducao> reproducoes = new List <Reproducao> ();
        public Principal()
        {
            InitializeComponent();
        }
        void CarregaForm(Form form)
        {
            form.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Location = new Point(panel1.Width / 2 - form.Width / 2, panel1.Height / 2 - form.Height / 2);
            form.Show();

        }

        void renderizaInterface()
        {
           
            foreach(Reproducao reproducao in reproducoes) 
            {
                
                PictureBox imagem = new PictureBox();
                imagem.LoadAsync(reproducao.link_imagem);
                imagem.SizeMode = PictureBoxSizeMode.Zoom;
                imagem.Size = new Size(200, 200);
                panel3.Controls.Add(imagem);
                imagem.Location = new Point(panel3.Width, 0);
                //imagem.Click imagem.id
            }

        }


        private void Principal_Load(object sender, EventArgs e)
        {
            Reproducao reproducao = new Reproducao();
            reproducoes = reproducao.buscaTodosFilmes();
            renderizaInterface();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnResenha_Click(object sender, EventArgs e)
        {
            
            CarregaForm(new Resenha());
            btnResenha.BackColor = Color.Gray;
            btnProducoes.BackColor = Color.Black;
            
        }

        private void btnProducoes_Click(object sender, EventArgs e)
        {
            CarregaForm(new Principal());
            btnProducoes.BackColor = Color.Gray;
            btnResenha.BackColor = Color.Black;
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
