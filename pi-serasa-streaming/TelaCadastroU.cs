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
            btnTermos.Checked = false;
            comboGenero.Text= string.Empty;
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




            if (nome == "" || senha == "" || email == "" || genero == "" || data_nascimento == "" || btnTermos.Checked == false) 
            {
                MessageBox.Show("Usuário já cadastrado ou campo incorreto!");
            }
            else
            {
                TelaU telaUsuario = new TelaU();
                Usuario usuario = new Usuario(0, nome, email, senha, false, genero, data_nascimento, false);
                usuario.Insere(usuario);

                MessageBox.Show(" Cadastro conclúido com sucesso!");
                painelCadastro.Visible = true;
                telaUsuario.Show();
            }

            limpaCampos();
            Principal principal= new Principal();
            principal.Show();
          //  TelaPagamento telaPagamrnto = new TelaPagamento();
           // telaPagamrnto.Show();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
