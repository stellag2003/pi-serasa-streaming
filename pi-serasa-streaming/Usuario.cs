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

        public Usuario(int id, string nome, string email, string senha, bool moderador, string genero, int dataNascimento, bool premium)
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

            List<Usuario> tarefas = new List<Usuario>();
            //Para cada linha dentro da tabela.rows
            //Ele guarda na variável linha o valor do loop atual dentro da tabela
            foreach (DataRow linha in tabela.Rows)
            {
                Usuario usuario = carregaDados(linha);
                usuario.Add(usuario);
            }
            return usuario;
        }


        //DataRow retorna apenas uma linha
        public Usuario BuscaPorId(int id)
        {
            string query = $"SELECT * FROM usuario WHERE id= {id};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;
        }



        public Usuario BuscarPorNome(string nome)
        {
            string query = $"SELECT * FROM usuario WHERE nome= {nome};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;

        }

        public Usuario BuscarPorEmail(string email)
        {
            string query = $"SELECT * FROM usuario WHERE email= {email};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;
        }

        public Usuario BuscarPorSenha(string senha)
        {
            string query = $"SELECT * FROM usuario WHERE senha= {senha};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;

        }

        public Usuario BuscarPorModerador(bool moderador)
        {
            string query = $"SELECT * FROM usuario WHERE moderador= {moderador};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;

        }

        public Usuario BuscarPorGenero(string genero)
        {
            string query = $"SELECT * FROM usuario WHERE genero= {genero};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;

        }

        public Usuario BuscarPorDataNascimento(int dataNascimento)
        {
            string query = $"SELECT * FROM usuario WHERE data_nascimento= {dataNascimento};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
            return usuario;

        }

        public Usuario BuscarPorPremium(string senha)
        {
            string query = $"SELECT * FROM usuario WHERE senha= {senha};";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregaDados(tabela.Rows[0]);
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
            string email = linha["email"].ToString();
            string senha= linha["senha"].ToString();
            bool moderador = linha["moderador"].ToString() == "1" ? true : false;
            string genero = linha["genero"].ToString();
            int dataNascimento = int.Parse(linha["data_nascimento"].ToString());
            bool premium = linha["premium"].ToString() == "1" ? true : false;


            Usuario usuario = new Usuario(id, nome,email,senha,moderador,genero, dataNascimento,premium);
            return usuario;

        }

        // string nome, string email, string senha, bool moderador, string genero, int dataNascimento, bool premium







    }

}


