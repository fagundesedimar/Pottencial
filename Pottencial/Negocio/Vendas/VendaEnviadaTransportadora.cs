using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Entidades;
using Pottencial.Negocio.Vendas.Interface;

namespace Pottencial.Negocio.Vendas
{
    public class VendaEnviadaTransportadora : IEstadoVenda
    {//ESTADO ATUAL DE EM TRANSPORTE
        public void AprovadoPagamento(Venda venda)
        {
            throw new Exception("Venda já está em transporte, não pode ser aprovada novamente.");
        }

        public void CanceladaVenda(Venda venda)
        {
            throw new Exception("Venda já está em transporte, não pode ser cancelada.");
        }

        public void EnviadaTransportador(Venda venda)
        {
            throw new Exception("Venda já está em transporte.");
        }

        public void Entregue(Venda venda)
        {
            venda.EstadoAtual = new VendaEntregue();
        }
    }
}
