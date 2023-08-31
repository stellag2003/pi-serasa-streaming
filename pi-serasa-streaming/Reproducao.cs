using ConexaoBDComTelas;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace pi_serasa_streaming
{

    internal class Reproducao
    {
        public int id;
        public string nome;
        public int tempo;
        public string genero;
        public int avaliacao;

        public Reproducao(int id, string nome, int tempo, string genero, int avaliacao)
        {
            this.id = id;
            this.nome = nome;
            this.tempo = tempo; 
            this.genero = genero;   
            this.avaliacao = avaliacao;
        }

        public List<Reproducao> buscaTodosFilmes()
        {
            string query = "SELECT * FROM Reproducao;";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);

            List<Reproducao> reproducao = new List<Reproducao>();
           
            foreach (DataRow linha in tabela.Rows)
            {
                Reproducao reproducoes = carregaDados(linha);
                reproducoes.Add(reproducoes);
            }
            
            return reproducao; 
        }

        public Reproducao BuscaFilmeNome(string nome)
        {
            string query = $"SELECT * FROM reproducao WHERE nome;";
            DataTable tabela = Conexao.executaQuery(query);

        }
        public Usuario carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = (linha["nome"].ToString());
            int = int.Parse(linha["tempo"].ToString();
            string senha = linha["senha"].ToString();
            bool moderador = linha["moderador"].ToString() == "1" ? true : false;
            string genero = linha["genero"].ToString();
            int dataNascimento = int.Parse(linha["data_nascimento"].ToString());
            bool premium = linha["premium"].ToString() == "1" ? true : false;


            Usuario usuario = new Usuario(id, nome, email, senha, moderador, genero, dataNascimento, premium);
            return usuario;

        }
    }
  

}
