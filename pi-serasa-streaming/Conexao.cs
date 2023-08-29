﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexaoBDComTelas
{
    internal class Conexao
    {
       const string host = "localhost";
       const string banco = "08_lista_tarefas";
       const string usuario = "root";
       const string senha = "senac";

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
                return null;
            }

            finally 
            { 
                conexao.Close(); 
            }
         
        }
    }
}
