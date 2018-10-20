using System.Collections.Generic;

namespace DesignPatternsCSharp.StructuralPatterns
{
    public class Patron
    {
        private string _name;

        public Patron(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }

    public class FoodItem
    {
        public int DishId;
    }

    public interface IKitchenSection
    {
        FoodItem PrepDish(int DishId);
    }

    public class Order
    {
        public List<FoodItem> Appetizer;
        public List<FoodItem> Entree;
        public List<FoodItem> Drink;

        public Order()
        {
            Appetizer = new List<FoodItem>();
            Entree = new List<FoodItem>();
            Drink = new List<FoodItem>();
        }
    }

    public class ColdPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            DishWash();
            return new PeanutButterJelly() { DishId = dishId };
        }

        private void DishWash() { }
    }

    public class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            GlassWash();
            return new LentilSoup() { DishId = dishId };
        }

        private void GlassWash() { }
    }

    public class BarPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishId)
        {
            CupWash();
            return new OrangeJuice() { DishId = dishId };
        }

        private void CupWash() { }
    }
    
    public class PeanutButterJelly : FoodItem { }

    public class LentilSoup : FoodItem { }

    public class OrangeJuice : FoodItem { }

    public class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private HotPrep _hotPrep = new HotPrep();
        private BarPrep _barPrep = new BarPrep();

        public Order PlaceOrder(Patron patron, int? coldAppId = null, int? hotEntreeId = null, int? drinkId = null)
        {
            Order order = new Order();

            if (coldAppId != null) order.Appetizer.Add(_coldPrep.PrepDish((int)coldAppId));
            if (hotEntreeId != null) order.Entree.Add(_hotPrep.PrepDish((int)hotEntreeId));
            if (drinkId != null) order.Drink.Add(_barPrep.PrepDish((int)drinkId));
            
            return order;
        }
    }
}
