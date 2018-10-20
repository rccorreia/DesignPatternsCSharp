namespace DesignPatternsCSharp.StructuralPatterns
{
    public interface IOrderingSystem
    {
        string Place(string order);
    }

    public abstract class SendOrder
    {
        public IOrderingSystem restaurant;

        public abstract string Send();
    }

    public class SendDairyFreeOrder : SendOrder
    {
        public override string Send()
        {
            return restaurant.Place("Dairy-Free Order");
        }
    }

    public class SendGlutenFreeOrder : SendOrder
    {
        public override string Send()
        {
            return restaurant.Place("Gluten-Free Order");
        }
    }

    public class DinerOrders : IOrderingSystem
    {
        public string Place(string order)
        {
            return ($"Placing order for {order} at the Diner.");
        }
    }

    public class FancyRestaurantOrders : IOrderingSystem
    {
        public string Place(string order)
        {
            return ($"Placing order for {order} at the Fancy Restaurant.");
        }
    }
}
