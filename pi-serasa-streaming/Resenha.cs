﻿using System;
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
        List<string> comentarios = new List<string>();

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
            panel1.Location = new Point(ClientSize.Width / 3 - panel1.Size.Width / 3, ClientSize.Height / 3 - panel1.Size.Height / 2);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string comentario1 = txtComentario.Text;
            Comentario comentario = new Comentario();
            comentario.Insere(comentario1);

            //TextBox textBox = new TextBox();
            //textBox.Text = comentario.ToString();
            //panel2.Controls.Clear();
            //panel2.Controls.Add(textBox);

            listComentarios.Show();
            for (int i = 0; i < comentarios.Count; i++)
            {
                listComentarios.Items.Add(comentarios[i]);
            }

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
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            //Comentario comentario = new Comentario();
            //comentarios = comentario.buscaTodos();
            
        }
    }
}
