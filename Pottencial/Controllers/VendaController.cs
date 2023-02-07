using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Pottencial.Entidades;
using Pottencial.Negocio.Vendas;
using Pottencial.Enumeradores;

namespace Pottencial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        public static readonly List<Venda> Vendas = new List<Venda>();
        public static readonly List<Vendedor> Vendedores = new List<Vendedor>
        {
            new Vendedor(1, "Edimar Fagundes", "00000000001", "edimar@email", "33333333"),
            new Vendedor(2, "Dimas", "00000000002", "dimas@email", "999999999")
        };

        public static readonly List<Item> itens = new List<Item> { 
            new Item(1, "CANETA", 250.0),
            new Item(2, "LAPIS", 100.0),
            new Item(3, "PAPEL", 250.0)
        };

        //private static readonly ILogger<VendaController> _venda;

        //public VendaController(ILogger<VendaController> venda)
        //{
        //    _venda = venda;
        //}

        [HttpGet]
        public string RegistrarVenda(long vendedorId, string itens)
        {
            List<long> listItens = itens.Split(',').ToList().Select(x => Convert.ToInt64(x)).ToList();
            var vendaRegistrada = new Venda(vendedorId, listItens);
            Vendas.Add(vendaRegistrada);
            return JsonConvert.SerializeObject(vendaRegistrada);
        }

        [HttpGet]
        public string BuscarVenda(long vendaId)
        {
            var venda = Vendas.Select(x => x.Id == vendaId);
            return venda != null ? JsonConvert.SerializeObject(venda) : "Item nao existe na base de dados!";
        }

        [HttpPost]
        public string AtualizarVenda(long vendaId, long vendedorId, long statusVenda, string itens)
        {
            var venda = Vendas.Select(x => x.Id == vendaId).FirstOrDefault();

            if (Vendas.Exists(x => x.Id == vendaId))
            {
                Vendas.ForEach(x =>
                {
                    if (x.Id == vendaId)
                    {
                        x.VendedorId = vendedorId;
                        x.AplicaEstadoAtualByStatusId(statusVenda);
                        x.Itens = itens.Split(',').ToList().Select(x => Convert.ToInt64(x)).ToList();
                    }
                });

                return "Item Atualizado com sucesso! Dados Atuais: " + JsonConvert.SerializeObject(venda);
            }
            else
            {
                return "Item nao existe na base de dados!";
            }
        }
    }
}
