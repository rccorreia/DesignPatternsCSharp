using System.Collections.Generic;

namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Sandwich
    {
        protected string Name;

        public Sandwich()
        {
            CreateIngredients();
            DefineSandwichName();
        }

        protected abstract void CreateIngredients();
        protected abstract void DefineSandwichName();

        public string Cook()
        {
            return $"The {Name} sandwich is ready";
        }

        public List<IIngredient> Ingredients { get; } = new List<IIngredient>();
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
            Name = "HotDog";
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
            Name = "BrazilianBauru";
        }
    }
}
