using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Entidades;
using Pottencial.Negocio.Vendas.Interface;

namespace Pottencial.Negocio.Vendas
{
    public class VendaEntregue : IEstadoVenda
    {//ESTADO ATUAL DE ENTREGUE
        public int Id { get; set; }

        public void AprovadoPagamento(Venda venda)
        {
            throw new Exception("Venda já está em estado de entregue, não pode ser aprovada.");
        }

        public void CanceladaVenda(Venda venda)
        {
            throw new Exception("Venda já está em estado de entregue, não pode ser cancelada.");
        }

        public void EnviadaTransportador(Venda venda)
        {
            throw new Exception("Venda já está em estado de entregue, não pode ser enviada ao transportador novamente.");
        }

        public void Entregue(Venda venda)
        {
            throw new Exception("Venda já está em estado de entregue.");
        }
    }
}
