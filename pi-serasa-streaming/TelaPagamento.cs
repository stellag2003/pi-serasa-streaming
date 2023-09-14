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
            if (txtCartao.Texts.Length == 0 || txtCartao.Texts.Length >= 17)
            {
                MessageBox.Show("Digite um número válido");
            }

            if (txtNome.Texts.Length == 0 || txtNome.Texts.Length >= 80)
            {
                MessageBox.Show("Digite um nome válido");
            }

            if (txtCPF.Texts.Length == 0 || txtCPF.Texts.Length >= 12)
            {
                MessageBox.Show("Digite um CPF válido");
            }

            if (txtCVV.Texts.Length == 0 || txtCVV.Texts.Length >= 4)
            {
                MessageBox.Show("Digite um CVV válido");
            }
        }

        private void txtNome__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
             string cpf;
             string cvv;
             string numeroCartao;

           
        }

        private void TelaPagamento_Load_1(object sender, EventArgs e)
        {

        }
    }
}
