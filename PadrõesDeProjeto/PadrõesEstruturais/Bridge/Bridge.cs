using System;

namespace PadrõesDeProjeto.PadrõesEstruturais.Bridge
{
    public class Bridge
    {
    }

    public interface IRestauranteDoPedidoDeRefeição
    {
        string CriarPedido(string pedido);
    }

    public abstract class PedidoDeRefeição
    {
        public IRestauranteDoPedidoDeRefeição restauranteDoPedidoDeRefeição;

        public abstract string EnviarPedido();
    }

    public class PedidoDeRefeiçãoSemLactose : PedidoDeRefeição
    {
        public override string EnviarPedido()
        {
            return restauranteDoPedidoDeRefeição.CriarPedido("Refeição sem Lactose");
        }
    }

    public class PedidoDeRefeiçãoSemGlúten : PedidoDeRefeição
    {
        public override string EnviarPedido()
        {
            return restauranteDoPedidoDeRefeição.CriarPedido("Refeição sem Glúten");
        }
    }

    public class PedidosParaRestauranteMineiro : IRestauranteDoPedidoDeRefeição
    {
        public string CriarPedido(string pedido)
        {
           return ($"Criando pedido " + pedido + " para o restaurante Mineiro.");
        }
    }
    
    public class PedidosParaRestauranteBaiano : IRestauranteDoPedidoDeRefeição
    {
        public string CriarPedido(string pedido)
        {
            return ($"Criando pedido " + pedido + " para o restaurante Baiano.");
        }
    }
}
