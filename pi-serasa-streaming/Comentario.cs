using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_streaming
{
    internal class Comentario
    {
        string conteudo;
        Usuario usuario;
        string comentario;

       public Comentario(string conteudo)
       {
            this.conteudo = conteudo;
           
       }

        public Comentario() 
        {

        }

        public List<Comentario> buscaTodos()
        {
            string query = "SELECT * FROM comentario";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);

            List<Comentario> comentarios = new List<Comentario>();
            //Para cada linha dentro da tabela.rows
            //Ele guarda na variável linha o valor do loop atual dentro da tabela
            foreach (DataRow linha in tabela.Rows)
            {
                Comentario comentario = carregaDados(linha);
                comentarios.Add(comentario);
            }
            return comentarios;
        }


        public Comentario BuscarPorComentario(string conteudo)
        {
            string query = $"SELECT * FROM comentario WHERE conteudo = {conteudo};";
            DataTable tabela = Conexao.executaQuery(query);
            Comentario comentario = carregaDados(tabela.Rows[0]);
            return comentario;

        }

        public Comentario AddComentario(string comentario)
        {
            string query = $"INSERT INTO reproducao (comentario) VALUES ('{comentario}');";
        }


        public Comentario carregaDados(DataRow linha)
        {
            string conteudo = (linha["conteudo"].ToString());
                       

            Comentario comentario = new Comentario (conteudo);
            return comentario;

        }
    }

}
