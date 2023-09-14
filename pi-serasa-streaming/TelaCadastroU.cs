using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        void limpaCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtData.Clear();
           // btnTermos.Checked = false;
            comboGenero.Text= string.Empty;
        }

        private void ValidaForm()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o nome do usuário");
                txtNome.Focus();
               // return false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Informe o e-mail do usuário");
                txtEmail.Focus();
                //return false;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe uma senha");
                txtSenha.Focus();
               // return false;
            }
            else if (txtData.Text == "    -  -  ")
            {
                MessageBox.Show("Informe uma data de nascimento");
                txtData.Focus();
                //return false;
            }
            else if (comboGenero.Text == "")
            {
                MessageBox.Show("Selecione um gênero");
                comboGenero.Focus();
               // return false;
            }
            else if (btnTermos.Checked == true)
            {
                MessageBox.Show("Os termos de uso não foi confirmado");
                btnTermos.Focus();
                //return false;
            }
        }


        private void TelaCadastroU_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            painelCadastro.Location = new Point(ClientSize.Width / 2 - painelCadastro.Size.Width / 2, ClientSize.Height / 2 - painelCadastro.Height / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string data_nascimento = txtData.Text;
            string genero = comboGenero.Text;

            ValidaForm();


            //if (nome == "" || senha == "" || email == "" || genero == "" || data_nascimento == "" || btnTermos.Checked == false) 
            //{
            //    MessageBox.Show("Usuário já cadastrado ou campo incorreto!");
            //}
            //else
            //{
            //    Usuario usuario = new Usuario(0, nome, email, senha, false, genero, data_nascimento, false);
            //    usuario.Insere(usuario);
            //    MessageBox.Show(" Cadastro conclúido com sucesso!");
            //    painelCadastro.Visible = true;
            //}

           //limpaCampos();

            TelaPagamento telaPagamrnto = new TelaPagamento();
            telaPagamrnto.Show();
        }
    }
}
