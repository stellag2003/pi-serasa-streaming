using System;
using System.Collections.Generic;
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
    }
}
