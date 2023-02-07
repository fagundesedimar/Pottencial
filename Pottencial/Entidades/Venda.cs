using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pottencial.Negocio.Vendas.Interface;
using Pottencial.Negocio.Vendas;

namespace Pottencial.Entidades
{
    public class Venda
    {
        public long Id { get; set; }
        public long VendedorId { get; set; }
        public DateTime Data { get; set; }
        public List<long> Itens { get; set; }
        public IEstadoVenda EstadoAtual { get; set; }

        public Venda(long vendedorId, List<long> itens)
        {
            Id = Convert.ToInt64(new Random(100));
            VendedorId = vendedorId;            
            EstadoAtual = new AguardandoPagamento();
            Data = DateTime.Now;
            Itens = itens;
        }

        public void AdicionaItem(Item item)
        {
            //item precisa ser valido
            if (item.Id > 0)
            {
                Itens.Add(item.Id);
            }
            else
            {
                throw new Exception("E necessário um item válido!");
            }
        }

        public void AdicionaItem(long id, String descricao, double valor)
        {
            Item item = new Item(id, descricao, valor);
            AdicionaItem(item);
        }

        public void AprovadoPagamento()
        {
            EstadoAtual.AprovadoPagamento(this);
        }

        public void CanceladaVenda()
        {
            EstadoAtual.CanceladaVenda(this);
        }

        public void EnviadaTransportador()
        {
            EstadoAtual.EnviadaTransportador(this);
        }

        public void Entregue()
        {
            EstadoAtual.Entregue(this);
        }

        public void AplicaEstadoAtualByStatusId(long statusVenda)
        {
            switch (statusVenda)
            {
                case (long)Enumeradores.Enumeradores.StatusVenda.PagamentoAprovado: 
                    AprovadoPagamento();
                    break;
                case (long)Enumeradores.Enumeradores.StatusVenda.EnviadoTransportadora:
                    EnviadaTransportador();
                    break;
                case (long)Enumeradores.Enumeradores.StatusVenda.Entregue:
                    Entregue();
                    break;
                case (long)Enumeradores.Enumeradores.StatusVenda.Cancelada:
                    CanceladaVenda();
                    break;
                default:
                    break;
            }
        }
    }

}
