using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_streaming
{
    internal class Coment
    {
        // id, descricao, concluido,criado_em
        public int id;
        public int id_usuario;
        public string comentario;
        public string criado_em;

        public Coment()
        {

        }

        public Coment(int id, int id_usuario, string comentario,string criado_em)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.comentario = comentario;
            this.criado_em = criado_em;
        }


        public List<Coment> buscaTodos()
        {
            string query = "SELECT * FROM comentarios";

            DataTable resultados = Conexao.executaQuery(query);
            if (resultados == null)
                return null;
            List<Coment> coments= new List<Coment>();
            foreach(DataRow row in resultados.Rows)
            {
                Coment coment = carregaDados(row);
                coments.Add(coment);

            }
            return coments;
        }

        public List<Coment> buscaTodosPorIdUsuario( int id_usuario)
        {
            string query = $"SELECT * FROM comentarios WHERE id_usuario = {id_usuario};";
            
            DataTable resultados = Conexao.executaQuery(query);
            if (resultados == null)
                return null;
            List<Coment> coments = new List<Coment>();
            foreach (DataRow row in resultados.Rows)
            {
                Coment coment = carregaDados(row);
                coments.Add(coment);

            }
            return coments;
        }



        //DataRow retorna apenas uma linha
        public Coment BuscaPorId(int id)
        {
            string query = $"SELECT * FROM comentarios WHERE id= {id};";
            DataTable tabela = Conexao.executaQuery(query);
            Coment coment = carregaDados(tabela.Rows[0]);
            return coment;
        }

        public Coment BuscarPorComentario(string comentario)
        {
            string query = $"SELECT * FROM comentarios WHERE comentario = '{comentario}';";
            DataTable tabela = Conexao.executaQuery(query);
            Coment coment = carregaDados(tabela.Rows[0]);
            return coment;

        }

        public void Insere(Coment coment)
        {
            
            string query = $"INSERT INTO comentarios (id_usuario, comentario) VALUES({coment.id_usuario},'{coment.comentario}');";
            Conexao.executaQuery(query);
        }



        // Recebe a linha de uma tabela e retorna ela no formato de classe
        public Coment carregaDados(DataRow row)
        {
            int id =int.Parse(row["id"].ToString());
            int id_usuario = int.Parse(row["id_usuario"].ToString());
            string comentario = (row["comentario"].ToString());
            string criado_em = row["criado_em"].ToString() ;

            Coment coment= new Coment(id, id_usuario, comentario,criado_em);
            return coment;

        }

       




    }

    }

