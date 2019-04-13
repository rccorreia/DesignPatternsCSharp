using System.Collections.Generic;

namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Sandwich
    {
        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<IIngredient> Ingredients { get; } = new List<IIngredient>();
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
