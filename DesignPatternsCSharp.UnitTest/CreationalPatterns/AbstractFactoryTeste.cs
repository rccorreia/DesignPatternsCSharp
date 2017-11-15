using DesignPatternsCSharp.CreationalPatterns.AbstractFactory;
using FluentAssertions;
using Xunit;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns
{
    public class AbstractFactoryTeste
    {
        [Fact]
        public void ShouldCreateASpaghettiMealWhenCreateMealFromAdultCuisineFactoryIsCalled()
        {
            var spaghettiMeal = new Spaghetti();
            var adultCuisine = new AdultCuisineFactory();

            adultCuisine.CreateMeal().Should().BeOfType(spaghettiMeal.GetType());
        }

        [Fact]
        public void ShouldCreateABrazilianDutchPieDessertWhenCreateDessertFromAdultCuisineFactoryIsCalled()
        {
            var brazilianDutchPieDessert = new BrazilianDutchPie();
            var adultCuisine = new AdultCuisineFactory();

            adultCuisine.CreateDessert().Should().BeOfType(brazilianDutchPieDessert.GetType());
        }

        [Fact]
        public void ShouldCreateARiceWithBroccoliMealWhenCreateMealFromKidCuisineFactoryIsCalled()
        {
            var riceWithBroccoliMeal = new RiceWithBroccoli();
            var kidCuisine = new KidCuisineFactory();

            kidCuisine.CreateMeal().Should().BeOfType(riceWithBroccoliMeal.GetType());
        }

        [Fact]
        public void ShouldCreateAChocolateCakeDessertWhenCreateDessertFromKidCuisineFactoryIsCalled()
        {
            var chocolateCakeDessert = new ChocolateCake();
            var kidCuisine = new KidCuisineFactory();

            kidCuisine.CreateDessert().Should().BeOfType(chocolateCakeDessert.GetType());
        }
    }
}
