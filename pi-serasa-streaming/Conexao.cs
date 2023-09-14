using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_streaming
{
    internal class Conexao
    {

        // Site para ver o banco: https://auth-db793.hstgr.io/
        const string host = "srv793.hstgr.io";
       const string banco = "u647084545_serasa_ssgc";
       const string usuario = "u647084545_serasa_ssgc";
       const string senha = "Serasa2023";

        const string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
        static MySqlConnection conexao = new MySqlConnection(dadosConexao);


               
        


        public static DataTable executaQuery(string query)
        {
            try
            {
                conexao.Open();

                
                MySqlCommand comando = new MySqlCommand(query, conexao);

                MySqlDataReader dados = comando.ExecuteReader();
                DataTable tabela= new DataTable();
                tabela.Load(dados);


                return tabela;

                
            }



            catch (Exception erro)
            {
                Console.WriteLine("Erro ao realizar consulta: ");
                Console.WriteLine(erro.Message);
                MessageBox.Show(erro.Message);
                return null;
            }

            finally 
            { 
                conexao.Close(); 
            }
         
        }
    }
}
