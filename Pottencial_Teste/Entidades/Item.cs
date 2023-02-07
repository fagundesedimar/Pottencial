using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pottencial.Entidades
{
    public class Item
    {
        public long Id { get; set; }
        public String Descricao { get; set; }
        public double Valor { get; set; }

        public Item(long id, string descricao, double valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }


    }
}
