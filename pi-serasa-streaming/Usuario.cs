using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi_serasa_streaming
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;
       

        public Usuario(string nome, string email, string password)
        {
            this.nome = nome;
            this.email = email;
            this.senha = password;
            
        }

    }
}
