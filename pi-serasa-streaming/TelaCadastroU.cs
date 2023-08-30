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
            
            

            Usuario usuario = new Usuario(nome, email, senha);
            usuarios.Add(usuario);

            
            if (nome == txtNome.Text && senha == txtSenha.Text && email == txtEmail.Text && btnTermos.Checked==true)
            {
                MessageBox.Show(" Cadastro conclúido com sucesso!");
                painelCadastro.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário já cadastrado ou campo incorreto!");
               
            }

            limpaCampos();

        }
    }
}
