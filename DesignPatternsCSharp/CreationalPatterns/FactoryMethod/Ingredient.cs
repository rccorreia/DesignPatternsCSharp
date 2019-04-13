namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Ingredient
    {
        public decimal Calories { get; protected set; }
        public string IngredientName() => GetType().Name;

    };

    public class Bread : Ingredient
    {
        public Bread()
        {
            Calories = 100.57M;
        }
    };

    public class Sausage : Ingredient
    {
        public Sausage()
        {
            Calories = 543.21M;
        }
    };

    public class PotatoSticks : Ingredient
    {
        public PotatoSticks()
        {
            Calories = 193.20M;
        }
    };

    public class Cheese : Ingredient
    {
        public Cheese()
        {
            Calories = 300.01M;
        }
    };

    public class Ham : Ingredient
    {
        public Ham()
        {
            Calories = 250.89M;
        }
    };

    public class Tomato : Ingredient
    {
        public Tomato()
        {
            Calories = 47.22M;
        }
    };
}
