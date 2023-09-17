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
        List<Comentario> comentarios = new List<Comentario>();

        public Resenha()
        {
            InitializeComponent();
        }
        void limpaCampos()
        {
            txtComentario.Clear();
        }

        //private void iconPictureBox6_Click(object sender, EventArgs e)
        //{

        //}

        //private void panel1_Paint(object sender, PaintEventArgs e)
        //{
        //    WindowState = FormWindowState.Maximized;
        //    panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2, ClientSize.Height / 2 - panel1.Size.Height / 2);
        //}

        //public void button1_Click(object sender, EventArgs e)
        //{
        //    string comentario1 = txtComentario.Text;
        //    Comentario comentario = new Comentario();
        //    comentario.Insere(comentario1);

        //    foreach (Comentario co in comentarios)
        //    {
        //        TextBox textBox = new TextBox();
        //        textBox.Text = comentario.ToString();
        //        panel2.Controls.Add(textBox);
        //        return;
        //    }


        //}

        public void txtComentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resenha_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;
            painel.Location = new Point(ClientSize.Width / 2 - painel.Size.Width / 2, ClientSize.Height / 2 - painel.Height / 2);
            menu.Location = new Point(400, -30);
            menu.Size = new Size(ClientSize.Width, 100);

            pictureBox1.Visible = true;
            pictureBox1.LoadAsync(Program.reproducao.link_assistir);

            pictureBox1.Location = new Point(0, 100);
            pictureBox1.Size = new Size(600, 280);


            lblUser.Text = Program.usuario.nome;

            Coment coment = new Coment();
            List<Coment> comentario = coment.buscaTodos();



            tabelaTodaTarefas.Columns.Add("id", "ID");
            tabelaTodaTarefas.Columns.Add("comentario", "Comentario");
            tabelaTodaTarefas.Columns.Add("data", "Data");

            foreach (Coment c in comentario)
            {
                tabelaTodaTarefas.Rows.Add(c.id, c.comentario, c.criado_em);
            }

            comentario = coment.buscaTodosPorIdUsuario(Program.usuario.id);

            tabelaTarefasUsuario.Columns.Add("id", "ID");
            tabelaTarefasUsuario.Columns.Add("comentarios", "Comentarios");
            tabelaTarefasUsuario.Columns.Add("data", "Data");

            foreach (Coment c in comentario)
            {
                tabelaTarefasUsuario.Rows.Add(c.id, c.comentario, c.criado_em);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            //Comentario comentario = new Comentario();
            //comentarios = comentario.buscaTodos();

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            string comentario = txtComentario.Text;

            Coment coment = new Coment(0, Program.usuario.id, comentario, null);
            coment.Insere(coment);
            limpaCampos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabelaTarefasUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
