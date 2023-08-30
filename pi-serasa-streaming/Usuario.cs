using ConexaoBDComTelas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_streaming
{
    internal class Usuario
    {
        int id;
        string nome;
        string email;
        string senha;
        bool moderador;
        string genero;
        int dataNascimento;
        bool premium;
        Postagem postagem;





        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, string senha, bool moderador,string genero, int dataNascimento, bool premium)
        {
            this.id = id;
            this.nome = nome;   
            this.email = email;
            this.senha = senha;
            this.moderador= moderador;
            this.genero= genero;
            this.dataNascimento= dataNascimento;
            this.premium= premium;
        }


        public List<Usuario> buscaTodos()
        {
            string query = "SELECT * FROM usuario;";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);

            List<Usuario> usuario = new List<Usuario>();
            //Para cada linha dentro da tabela.rows
            //Ele guarda na variável linha o valor do loop atual dentro da tabela
            foreach (DataRow linha in tabela.Rows)
            {
                Usuario usuario = carregaDados(linha);
                usuario.Add(usuario);
            }
            return Usuario;
        }

        public Usuario BuscaEmail(string email)
        {
            string query = $"SELECT * FROM usuario WHERE email;";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(usuario.Rows[0]);
            return usuario;


        }


        //DataRow retorna apenas uma linha
        public Tarefa BuscaPorId(int id)
        {
            string query = $"SELECT * FROM tarefas WHERE id= {id};";
            DataTable tabela = Conexao.executaQuery(query);
            Tarefa tarefa = carregaDados(tabela.Rows[0]);
            return tarefa;
        }

        public Tarefa BuscarPorEmail(string email)
        {
            string query = $"SELECT * FROM usuario WHERE descricao= {email};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario = carregaDados(tabela.Rows[0]);
            return usuario;

        }

        public void Insere(Tarefa tarefa)
        {
            int concluido = tarefa.concluido == true ? 1 : 0;
            string query = $"INSERT INTO tarefas (descricao,concluido) VALUES('{tarefa.descricao}',{concluido});";
            Conexao.executaQuery(query);
        }



        // Recebe a linha de uma tabela e retorna ela no formato de classe
        public Usuario carregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = (linha["nome"].ToString());
            string senha = (linha["senha"];ToString());
            bool premium = linha["premium"].ToString() == "1" ? true : false;
            string criado_em = linha["criado_em"].ToString();
            string email = linha["email"].ToString();

            Usuario usuario = new Usuario(id, email);
            return usuario;


        }
    }
}



   

   
