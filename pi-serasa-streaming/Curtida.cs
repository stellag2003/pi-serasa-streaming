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

    internal class Curtida
    {
        public int numero_curtidas;
        public bool curtida_curtida;

        public Curtida()
        {

        }

        public Curtida(int id, string nome, string tempo, string genero, string descricao, int avaliacao, string link_filme)
        {
            this.id = id;
            this.nome = nome;
            this.tempo = tempo;
            this.genero = genero;
            this.descricao = descricao;
            this.avaliacao = avaliacao;
            this.link_filme = link_filme;
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
            string query = $"SELECT * FROM reproducao WHERE {nome};";
            DataTable tabela = Conexao.executaQuery(query);
            Reproducao reproducao = carregaDados(tabela.Rows[0]);
            return reproducao;
        }

        public Reproducao DescricaoFilme(string descricao)
        {
            string query = $"SELECT descricao FROM reproducao WHERE nome = {nome};";
            DataTable tabela = Conexao.executaQuery(query);
            Reproducao reproducao = carregaDados(tabela.Rows[0]);
            return reproducao;
        }
        public Reproducao BuscaLink(string link_filme)
        {
            string query = $"SELECT link_filme FROM reproducao WHERE nome = {nome};";
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
            string descricao = (linha["descricao"].ToString());
            string link_filme = (linha["link_filme"].ToString());


            Reproducao reproducao = new Reproducao(id, nome, tempo, genero, descricao, avaliacao, link_filme);
            return reproducao;

        }
    }


}
