using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pi_serasa_streaming
{
    public partial class TelaCadastroU : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        public TelaCadastroU()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            painelCadastro.BackColor = Color.FromArgb(200, Color.Black);

        }

        void limpaCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtData.Clear();
            // btnTermos.Checked = false;
            comboGenero.Text = string.Empty;
        }


        private void TelaCadastroU_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painelCadastro.Location = new Point(ClientSize.Width / 2 - painelCadastro.Size.Width / 2 + 40, ClientSize.Height / 2 - painelCadastro.Height / 2 + 50);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string data_nascimento = txtData.Text;
            string genero = comboGenero.Text;

            string[] d = data_nascimento.Split("/");
            data_nascimento = d[2] + "-" + d[1] + "-" + d[0];

            if (nome == "" || senha == "" || email == "" || genero == "" || data_nascimento == "" || btnTermos.Checked == false)
            {
                MessageBox.Show("Usuário já cadastrado ou campo incorreto!");
            }
            else
            {
                // TelaU telaUsuario = new TelaU();
                Usuario usuario = new Usuario(0, nome, email, senha, false, genero, data_nascimento, false);
                usuario.Insere(usuario);
                MessageBox.Show(" Cadastro conclúido com sucesso!");
                painelCadastro.Visible = true;
                // telaUsuario.Show();
                this.Close();
                Principal principal = new Principal();
                principal.Show();
            }

            limpaCampos();

        }

        private void painelCadastro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
