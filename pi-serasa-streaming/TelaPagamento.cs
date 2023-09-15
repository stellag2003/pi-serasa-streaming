using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pi_serasa_streaming
{
    public partial class TelaPagamento : Form
    {
        public TelaPagamento()
        {
            InitializeComponent();
        }



        private void TelaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void wilBitTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wilBitTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void wilBitTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCartao__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //if (txtCartao.Texts.Length == 0 || txtCartao.Texts.Length >= 17)
            //{
            //    MessageBox.Show("Digite um número válido");
            //}

            //if (txtNome.Texts.Length == 0 || txtNome.Texts.Length >= 80)
            //{
            //    MessageBox.Show("Digite um nome válido");
            //}

            //if (txtCPF.Texts.Length == 0 || txtCPF.Texts.Length >= 12)
            //{
            //    MessageBox.Show("Digite um CPF válido");
            //}

            //if (txtCVV.Texts.Length == 0 || txtCVV.Texts.Length >= 4)
            //{
            //    MessageBox.Show("Digite um CVV válido");
            //}
        }

        private void txtNome__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            string cvv = txtCVV.Text;
            string numeroCartao = txtCartao.Text;
            string usuario = txtNome.Text;


            if (cpf.Count() == 11 || cvv.Count() == 3 || numeroCartao != "" || usuario != "")
            {
                Pagamento pagamentos = new Pagamento();
                pagamentos.AdicionarPagamento(pagamentos);
                //TelaU telaUsuario = new TelaU();
                //telaUsuario.Show();

            }
            else if (cpf.Count() == 11 || cvv.Count() == 3)
            {
                MessageBox.Show("CPF ou CVV com caracteres faltantes\nCPF: 11 dígitos\nCVV:3 dígitos");
            }

            Principal p = new Principal();
            p.Show();
        }

        private void TelaPagamento_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2, ClientSize.Height / 2 - panel1.Height / 2);
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void txtCartao__TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void btnConfirmar_Click_2(object sender, EventArgs e)
        {

        }
    }
}
