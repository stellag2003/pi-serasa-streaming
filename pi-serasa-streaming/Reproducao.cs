using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pi_serasa_streaming
{

    internal class Reproducao
    {
        public int id;
        public string nome;
        public string tempo;
        public string genero;
        public int avaliacao;

        public Reproducao() 
        {

        }

        public Reproducao(int id, string nome, string tempo, string genero, int avaliacao)
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

            List<Reproducao> reproducoes = new List<Reproducao>();

            foreach (DataRow linha in tabela.Rows)
            {
                Reproducao reproducao = carregaDados(linha);
                reproducoes.Add(reproducao);
            }

            return reproducoes;
        }

        public Reproducao BuscaFilmeNome(string nome)
        {
            string query = $"SELECT * FROM reproducao WHERE nome;";
            DataTable tabela = Conexao.executaQuery(query);
            Reproducao reproducao = carregaDados(tabela.Rows[0]);
            return reproducao;
        }

        public Reproducao carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = (linha["nome"].ToString());
            string tempo = linha["tempo"].ToString();
            string genero = linha["genero"].ToString();
            int avaliacao = int.Parse(linha["avaliacao"].ToString());



            Reproducao reproducao = new Reproducao(id, nome, tempo, genero, avaliacao);
            return reproducao;

        }
    }


}
