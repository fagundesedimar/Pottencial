using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Entidades;
using Pottencial.Negocio.Vendas.Interface;

namespace Pottencial.Negocio.Vendas
{
    public class Cancelada : IEstadoVenda
    {//ESTADO ATUAL DE CANCELADA
        public int Id { get; set; }

        public void AprovadoPagamento(Venda venda)
        {
            throw new Exception("Venda esta cancelada, não pode ser aprovada.");
        }

        public void CanceladaVenda(Venda venda)
        {
            throw new Exception("Venda já está em estado de cancelada, não pode ser cancelada novamente.");
        }

        public void EnviadaTransportador(Venda venda)
        {
            throw new Exception("Venda esta cancelada, não pode ser enviada ao transportador novamente.");
        }

        public void Entregue(Venda venda)
        {
            throw new Exception("Venda esta cancelada, não pode ser entregue.");
        }
    }
}
