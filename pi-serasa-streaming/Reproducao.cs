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
        public string descricao;
        public int avaliacao;
        public string link_filme;
        public string link_imagem;
        public string link_assistir;

        public Reproducao()
        {

        }

        public Reproducao(int id, string nome,  string descricao, int avaliacao, string link_filme, string link_imagem, string link_assistir)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.avaliacao = avaliacao;
            this.link_filme = link_filme;
            this.link_imagem = link_imagem;
            this.link_assistir = link_assistir;
        }

        public List<Reproducao> buscaTodosFilmes()
        {
            string query = "SELECT * FROM reproducao;";
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


        public Reproducao BuscaPorId(int id)
        {
            string query = $"SELECT * FROM reproducao WHERE id = {id};";
            DataTable tabela = Conexao.executaQuery(query);
            Reproducao reproducao = carregaDados(tabela.Rows[0]);
            return reproducao;
        }


        public Reproducao BuscaFilmeNome(string nome)
        {
            string query = $"SELECT * FROM reproducao WHERE nome LIKE LOWER('%{nome}%');";
            DataTable tabela = Conexao.executaQuery(query);
            Reproducao reproducao = carregaDados(tabela.Rows[0]);
            return reproducao;
        }

        public void AdicionarFilmes(Reproducao reproducao)
        {
            string query = $"INSERT INTO usuario (nome, descricao, link_filme, link_assistir) VALUES('{reproducao.nome}','{reproducao.descricao}','{reproducao.link_filme}', '{reproducao.link_assistir}');";
            Conexao.executaQuery(query);
        }

        public Reproducao carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = (linha["nome"].ToString());
            int avaliacao = linha["avaliacao"] == null ? int.Parse(linha["avaliacao"].ToString()) : 0;
            string descricao = (linha["descricao"].ToString());
            string link_filme = (linha["link_filme"].ToString());
            string link_imagem = (linha["link_imagem"].ToString());
            string link_assistir = (linha["link_assistir"].ToString());


            Reproducao reproducao = new Reproducao(id, nome, descricao, avaliacao, link_filme, link_imagem, link_assistir);
            return reproducao;

        }
    }


}
