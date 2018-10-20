using System.Text;

namespace DesignPatterns.BehavioralPatterns
{
    public abstract class Bread
    {
        protected abstract string MixIngredients();

        protected abstract string Bake();

        protected virtual string Slice()
        {
            return ("Slicing the " + GetType().Name + " bread!");
        }

        public string Make()
        {
            StringBuilder actionsReturn = new StringBuilder();

            actionsReturn.Append(MixIngredients());
            actionsReturn.Append(Bake());
            actionsReturn.Append(Slice());

            return actionsReturn.ToString();
        }
    }

    public class TwelveGrain : Bread
    {
        protected override string MixIngredients() => "Gathering Ingredients for 12-Grain Bread.";
        protected override string Bake() => "Baking the 12-Grain Bread. (25 minutes).";
    }

    public class Sourdough : Bread
    {
        protected override string MixIngredients() => "Gathering Ingredients for Sourdough Bread.";
        protected override string Bake() => "Baking the Sourdough Bread. (20 minutes).";
    }

    public class WholeWheat : Bread
    {
        protected override string MixIngredients() => "Gathering Ingredients for Whole Wheat Bread.";
        protected override string Bake() => "Baking the Whole Wheat Bread. (15 minutes).";
    }
}
