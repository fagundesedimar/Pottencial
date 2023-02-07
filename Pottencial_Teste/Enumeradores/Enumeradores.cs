using Pottencial.Negocio.Vendas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Negocio.Vendas;

namespace Pottencial.Enumeradores
{
    public class Enumeradores
    {
        public enum StatusVenda
        {
            AguardandoPagamento,
            Entregue,
            Cancelada,
            PagamentoAprovado,
            EnviadoTransportadora
        }
    }
}
