namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Ingredient
    {
        public decimal Calories { get; protected set; }
        public int CookingTime { get; protected set; }
        public string IngredientName() => GetType().Name;
        public string Cook(int seconds) => seconds >= CookingTime ? CookedMessage() : NotCookedMessage();

        private string CookedMessage() => $"The {IngredientName()} is ready";
        private string NotCookedMessage() => $"Ops, the {IngredientName()} is not good";
    };

    public class Bread : Ingredient
    {
        public Bread()
        {
            Calories = 100.57M;
            CookingTime = 60;
        }
    };

    public class Sausage : Ingredient
    {
        public Sausage()
        {
            Calories = 543.21M;
            CookingTime = 240;
        }
    };

    public class PotatoSticks : Ingredient
    {
        public PotatoSticks()
        {
            Calories = 193.20M;
            CookingTime = 100;
        }
    };

    public class Cheese : Ingredient
    {
        public Cheese()
        {
            Calories = 300.01M;
            CookingTime = 30;
        }
    };

    public class Ham : Ingredient
    {
        public Ham()
        {
            Calories = 250.89M;
            CookingTime = 50;
        }
    };

    public class Tomato : Ingredient
    {
        public Tomato()
        {
            Calories = 47.22M;
            CookingTime = 20;
        }
    };

}
