//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace pi_serasa_streaming
//{
//    internal class Pagamento
//    {
//        //Vou ter que criar um coluna para  número do cartão e CVV, para armazenar referente
//        //ao usuário que está cadastrando o cartão no pagamento. 
//        public int id;
//        public int usuarioPremium;
//        public string cpf;
//        public string cvv;
//        public string numeroCartao;
//        Usuario usuario;

//        public Pagamento()
//        {

//        }

//        public Pagamento(int id, int usuarioPremium, string cpf, string cvv, string numeroCartao, Usuario usuario)
//        {
//            this.id = id;
//            this.usuarioPremium = usuarioPremium;
//            this.usuario = usuario;
//            this.cpf = cpf;
//            this.numeroCartao = numeroCartao;
//            this.cvv = cvv;
//        }
        
//        public List<Pagamento> BuscaTodosPag()
//        {
//            string query = "SELECT * FROM pagamento;";
//            Conexao.executaQuery(query);
//            DataTable tabela = Conexao.executaQuery(query);

//            List<Pagamento> pagamentos = new List<Pagamento>();

//            foreach (DataRow linha in tabela.Rows)
//            {
//                Pagamento pagamento = carregaDados(linha);
//                pagamentos.Add(pagamento);
//            }

//                return pagamentos;
//        }

//        public void AdicionarPagamento(Pagamento pagamento, Usuario usuario)
//        {
//            string query = $"INSERT INTO pagamento (usuarioPremium,cpf, cvv, numeroCartao) VALUES('{pagamento.usuarioPremium = 1}','{pagamento.cpf}','{pagamento.cvv}', '{pagamento.numeroCartao}');";
//            Conexao.executaQuery(query);
//        }

//        public void VerificaPag(int usuarioPremium)
//        {
//            string query = $"SELECT * FROM pagamento WHERE usuario_id = '{usuarioPremium}';";
//            Conexao.executaQuery(query);
//            DataTable tabela = Conexao.executaQuery(query);
//            List<Pagamento> pagamentos = new List<Pagamento>();

//            //aqui vai estar errado, estou pensando em um modo de ficar correto.

//            if (int.Parse(query) == 1)
//            {
//                MessageBox.Show("Você é usuário premium");
//            }
//            else
//            {
//                MessageBox.Show("Você precisa ser premium para ter acesso! ");
//            }
//        }

//        public Pagamento carregaDados(DataRow linha)
//        {
//            int id = int.Parse(linha["id"].ToString());
//            int usuarioPremium = int.Parse(linha["usuarioPremium"].ToString());
//            Pagamento pagamento = new Pagamento(id, usuarioPremium,cpf,cvv,numeroCartao,usuario);
//            return pagamento;
//        }




//    }

//}
