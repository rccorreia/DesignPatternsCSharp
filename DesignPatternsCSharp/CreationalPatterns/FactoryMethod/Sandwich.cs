using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Sandwich
    {
        protected string name;

        public Sandwich()
        {
            CreateIngredients();
            DefineSandwichName();
        }

        protected abstract void CreateIngredients();
        protected abstract void DefineSandwichName();

        public string Cook(int seconds) 
            => $"Wait a minute, we are cooking your {name}.\n" 
            + Ingredients.Select(x => x.Cook(seconds)).Aggregate((i, j) => i + "\n" + j)
            + "\nYour Sandwich is ready.";
        
        public string IngredientsList() => Ingredients.Select(x => x.IngredientName()).Aggregate((i, j) => i + " " + j);
        public decimal CaloriesCount() => Ingredients.Sum(x => x.Calories);

        public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
    }

    public class HotDog : Sandwich
    {
        protected override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Sausage());
            Ingredients.Add(new PotatoSticks());
            Ingredients.Add(new Bread());
        }

        protected override void DefineSandwichName()
        {
            name = "HotDog";
        }
    }

    public class BrazilianBauru : Sandwich
    {
        protected override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Cheese());
            Ingredients.Add(new Ham());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new Bread());
        }

        protected override void DefineSandwichName()
        {
            name = "BrazilianBauru";
        }
    }
}
