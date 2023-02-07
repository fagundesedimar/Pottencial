using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Entidades;
using Pottencial.Negocio.Vendas.Interface;

namespace Pottencial.Negocio.Vendas
{
    public class AguardandoPagamento : IEstadoVenda
    {
        public int Id { get; set; }

        public void AprovadoPagamento(Venda venda)
        {
            venda.EstadoAtual = new PagamentoAprovado();
            venda.EstadoAtual.Id = (int)Enumeradores.Enumeradores.StatusVenda.PagamentoAprovado;
        }

        public void CanceladaVenda(Venda venda)
        {
            venda.EstadoAtual = new Cancelada();
            venda.EstadoAtual.Id = (int)Enumeradores.Enumeradores.StatusVenda.Cancelada;
        }

        public void EnviadaTransportador(Venda venda)
        {
            // ja estou entregue
            throw new Exception("Venda já está aguardando pagamento, não pode ser enviada ao transportador diretamente, pagamento precisa ser aprovado antes.");
        }

        public void Entregue(Venda venda)
        {
            throw new Exception("Venda já está aguardando pagamento, não pode ser entregue ate que o pagamento seja efetuado.");
        }
    }
}
