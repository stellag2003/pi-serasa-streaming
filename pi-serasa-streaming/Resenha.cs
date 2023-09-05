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
        List <Comentario> comentarios = new List <Comentario> ();
        public Resenha()
        {
            InitializeComponent();
        }



        private void iconPictureBox6_Click(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2 , ClientSize.Height / 2 - panel1.Size.Height / 2);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string comentario = txtComentario.Text;
            Comentario comentario1= new Comentario();
            comentario1.Insere(comentario);


            TextBox textBox = new TextBox();
            textBox1.Text = comentario;
            

            

         
        }

        public void txtComentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resenha_Load(object sender, EventArgs e)
        {
            //Comentario comentario = new Comentario();
            //comentarios = comentario.Insere();
            //txtComentario.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Comentario comentario = new Comentario();
            comentarios = comentario.buscaTodos();
            
        }
    }
}
