using System.Collections.Generic;

namespace PadrõesDeProjeto.PadrõesEstruturais
{
    public class Facade
    {
    }

    public class Cliente
    {
        private string _name;

        public Cliente(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }

    public class ItemDoPedido
    {
        public int ID;
    }

    public interface EspecialidadeDaCozinha
    {
        ItemDoPedido PrepararItem(int ItemDoPedidoID);
    }

    public class Pedido
    {
        public List<ItemDoPedido> Refeições;
        public List<ItemDoPedido> Sobremesas;
        public List<ItemDoPedido> Bebidas;

        public Pedido()
        {
            Refeições = new List<ItemDoPedido>();
            Sobremesas = new List<ItemDoPedido>();
            Bebidas = new List<ItemDoPedido>();
        }
    }

    public class PreparaçãoDasRefeições : EspecialidadeDaCozinha
    {
        public ItemDoPedido PrepararItem(int itemDoPedidoID)
        {
            LavarOsPratos();
            return new FrangoÀMilanesa() { ID = itemDoPedidoID };
        }

        private void LavarOsPratos() { }
    }

    public class PreparaçãoDasSobremesas : EspecialidadeDaCozinha
    {
        public ItemDoPedido PrepararItem(int itemDoPedidoID)
        {
            LavarAsTaças();
            return new DoceDeNata() { ID = itemDoPedidoID };
        }

        private void LavarAsTaças() { }
    }

    public class PreparaçãoDasBebidas : EspecialidadeDaCozinha
    {
        public ItemDoPedido PrepararItem(int itemDoPedidoID)
        {
            LavarOsCopos();
            return new SucoDeLaranja() { ID = itemDoPedidoID };
        }

        private void LavarOsCopos() { }
    }

    public class FrangoÀMilanesa : ItemDoPedido { }

    public class DoceDeNata : ItemDoPedido { }

    public class SucoDeLaranja : ItemDoPedido { }

    public class Garçom
    {
        private PreparaçãoDasRefeições _preparaçãoDasRefeições = new PreparaçãoDasRefeições();
        private PreparaçãoDasSobremesas _preparaçãoDasSobremesas = new PreparaçãoDasSobremesas();
        private PreparaçãoDasBebidas _preparaçãoDasBebidas = new PreparaçãoDasBebidas();

        public Pedido CriarPedido(Cliente cliente, int? refeiçãoID = null, int? sobremesaID = null, int? bebidaID = null)
        {
            Pedido pedido = new Pedido();

            if (refeiçãoID != null) pedido.Refeições.Add(_preparaçãoDasRefeições.PrepararItem((int)refeiçãoID));
            if (sobremesaID != null) pedido.Sobremesas.Add(_preparaçãoDasSobremesas.PrepararItem((int)sobremesaID));
            if (bebidaID != null) pedido.Bebidas.Add(_preparaçãoDasBebidas.PrepararItem((int)bebidaID));
            
            return pedido;
        }
    }
}
