using System.Collections.Generic;

namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
        }
    }

    public class HotDog : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Sausage());
            Ingredients.Add(new PotatoSticks());
            Ingredients.Add(new Bread());
        }
    }

    public class BrazilianBauru : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Cheese());
            Ingredients.Add(new Ham());
            Ingredients.Add(new Tomato());
            Ingredients.Add(new Bread());
        }
    }
}
