using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pottencial.Entidades
{
    public class Vendedor
    {
        public long Id { get; private set; }
        public String Nome { get; private set; }
        public String Cpf { get; private set; }
        public String Email { get; private set; }
        public String Telefone { get; private set; }

        public Vendedor(long id, string nome, string cpf, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }
    }
}
