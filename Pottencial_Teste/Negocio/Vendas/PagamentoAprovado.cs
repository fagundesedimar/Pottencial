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

        public int Id { get; set; }

        public void AprovadoPagamento(Venda venda)
        {
            throw new Exception("Venda já está com pagamento aprovado, não pode ser aprovada novamente.");
        }

        public void CanceladaVenda(Venda venda)
        {
            venda.EstadoAtual = new Cancelada();
            venda.EstadoAtual.Id = (int)Enumeradores.Enumeradores.StatusVenda.Cancelada;
            //POSSIVEL IMPLEMENTAÇAO DE RESTITUIÇAO DE PAGAMENTO.
        }

        public void EnviadaTransportador(Venda venda)
        {
            venda.EstadoAtual = new VendaEnviadaTransportadora();
            venda.EstadoAtual.Id = (int)Enumeradores.Enumeradores.StatusVenda.EnviadoTransportadora;
        }

        public void Entregue(Venda venda)
        {
            throw new Exception("Venda já está com pagamento aprovado, não pode ser entregue, precisa primeiramente ser enviada ao transportador.");
        }
    }
}
