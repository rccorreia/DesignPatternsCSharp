namespace DesignPatternsCSharp.CreationalPatterns.AbstractFactory
{
    public abstract class RecipeFactory
    {
        public abstract Meal CreateMeal();
        public abstract Dessert CreateDessert();
    }

    public class AdultCuisineFactory : RecipeFactory
    {
        public override Meal CreateMeal()
        {
            return new Spaghetti();
        }

        public override Dessert CreateDessert()
        {
            return new BrazilianDutchPie();
        }
    }

    public class KidCuisineFactory : RecipeFactory
    {
        public override Meal CreateMeal()
        {
            return new RiceWithBroccoli();
        }

        public override Dessert CreateDessert()
        {
            return new ChocolateCake();
        }
    }
}
