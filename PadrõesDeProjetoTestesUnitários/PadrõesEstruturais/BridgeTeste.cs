using FluentAssertions;
using PadrõesDeProjeto.PadrõesEstruturais.Bridge;
using Xunit;

namespace PadrõesDeProjetoTestesUnitários.PadrõesEstruturais
{
    public class BridgeTeste
    {
        [Fact]
        public void DeveRetornarAMensagemDesejadaAoCriarUmPedidoParaRestauranteMineiro()
        {
            string mensagemDeRetorno;
            var mensagemDesejada = "Criando pedido Refeição sem Glúten para o restaurante Mineiro.";

            PedidoDeRefeição pedidoDeRefeição = new PedidoDeRefeiçãoSemGlúten();
            pedidoDeRefeição.restauranteDoPedidoDeRefeição = new PedidosParaRestauranteMineiro();
            mensagemDeRetorno = pedidoDeRefeição.EnviarPedido();

            mensagemDeRetorno.ShouldBeEquivalentTo(mensagemDesejada);
        }
    }
}
