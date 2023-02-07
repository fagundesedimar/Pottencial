using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Entidades;

namespace Pottencial.Negocio.Vendas.Interface
{
    public interface IEstadoVenda
    {
        public void AprovadoPagamento(Venda venda);
        public void CanceladaVenda(Venda venda);
        public void EnviadaTransportador(Venda venda);
        public void Entregue(Venda venda);
    }
}
