using Pottencial.Entidades;

namespace Pottencial_TDD
{
    public class VendaTest
    {
        [Fact]
        public void RegistraVenda()
        {
            long vendedorId = 1;
            string itens = "1,2";
            List<long> listItens = itens.Split(',').ToList().Select(x => Convert.ToInt64(x)).ToList();
            var venda = new Venda(vendedorId, listItens);
            var resultadoEsperado = true;

            var resultado = venda.VendaValida();

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void AtualizarVenda()
        {
            long vendedorId = 1;
            string itens = "1,2";
            List<long> listItens = itens.Split(',').ToList().Select(x => Convert.ToInt64(x)).ToList();
            var venda = new Venda(vendedorId, listItens);
            var resultadoEsperado = true;
            var resultado = venda.VendaValida();

            //Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void BuscaVenda()
        {
            long vendedorId = 1;
            string itens = "1,2";
            List<long> listItens = itens.Split(',').ToList().Select(x => Convert.ToInt64(x)).ToList();
            var venda = new Venda(vendedorId, listItens);
            var resultadoEsperado = true;

            var resultado = venda.VendaExiste();

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}