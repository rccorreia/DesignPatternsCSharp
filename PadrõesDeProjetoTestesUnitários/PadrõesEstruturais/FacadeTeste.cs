using FluentAssertions;
using PadrõesDeProjeto.PadrõesEstruturais;
using System.Linq;
using Xunit;

namespace PadrõesDeProjetoTestesUnitários.PadrõesEstruturais
{
    public class FacadeTeste
    {
        [Fact]
        public void DeveCriarUmPedidoComUmaRefeiçãoQuandoOClienteDesejarApenasUmaRefeição()
        {
            var garçom = new Garçom();
            var cliente = new Cliente("Ricardo");
            var identificadorDoFrangoÀMilanesa = 1;
            var frangoÀMilanesa = new FrangoÀMilanesa();

            var pedido = garçom.CriarPedido(cliente, refeiçãoID: identificadorDoFrangoÀMilanesa);

            pedido.Refeições.First().Should().BeOfType(frangoÀMilanesa.GetType(), "O pedido foi para um Frango à Milanesa");
            pedido.Sobremesas.Count().ShouldBeEquivalentTo(0, "Não pode existir sobremesa no pedido sem ser solicitada");
            pedido.Bebidas.Count().ShouldBeEquivalentTo(0, "Não pode existir bebida no pedido sem ser solicitada");
        }
    }
}
