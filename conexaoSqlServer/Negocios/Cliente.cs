using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexaoSqlServer.Negocios
{
    public class Cliente
    {

        public int codigo { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }


        public Cliente()
        {
        }

        public Cliente(int codigo, string nome, string endereco, string email)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
        }


    }
}
