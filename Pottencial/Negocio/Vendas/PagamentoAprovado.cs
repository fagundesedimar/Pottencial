using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Entidades;
using Pottencial.Negocio.Vendas.Interface;

namespace Pottencial.Negocio.Vendas
{
    public class PagamentoAprovado : IEstadoVenda
    {//ESTADO ATUAL DE PAGAMENTO APROVADO
        public void AprovadoPagamento(Venda venda)
        {
            throw new Exception("Venda já está com pagamento aprovado, não pode ser aprovada novamente.");
        }

        public void CanceladaVenda(Venda venda)
        {
            venda.EstadoAtual = new Cancelada();
            //POSSIVEL IMPLEMENTAÇAO DE RESTITUIÇAO DE PAGAMENTO.
        }

        public void EnviadaTransportador(Venda venda)
        {
            venda.EstadoAtual = new VendaEnviadaTransportadora();
        }

        public void Entregue(Venda venda)
        {
            throw new Exception("Venda já está com pagamento aprovado, não pode ser entregue, precisa primeiramente ser enviada ao transportador.");
        }
    }
}
