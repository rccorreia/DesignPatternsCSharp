using DesignPatternsCSharp.CreationalPatterns.AbstractFactory;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [Test]
        public void ShouldCreateASpaghettiMealWhenCreateMealFromAdultCuisineFactoryIsCalled()
        {
            var spaghettiMeal = new Spaghetti();
            var adultCuisine = new AdultCuisineFactory();

            adultCuisine.CreateMeal().Should().BeOfType(spaghettiMeal.GetType());
        }

        [Test]
        public void ShouldCreateABrazilianDutchPieDessertWhenCreateDessertFromAdultCuisineFactoryIsCalled()
        {
            var brazilianDutchPieDessert = new BrazilianDutchPie();
            var adultCuisine = new AdultCuisineFactory();

            adultCuisine.CreateDessert().Should().BeOfType(brazilianDutchPieDessert.GetType());
        }

        [Test]
        public void ShouldCreateARiceWithBroccoliMealWhenCreateMealFromKidCuisineFactoryIsCalled()
        {
            var riceWithBroccoliMeal = new RiceWithBroccoli();
            var kidCuisine = new KidCuisineFactory();

            kidCuisine.CreateMeal().Should().BeOfType(riceWithBroccoliMeal.GetType());
        }

        [Test]
        public void ShouldCreateAChocolateCakeDessertWhenCreateDessertFromKidCuisineFactoryIsCalled()
        {
            var chocolateCakeDessert = new ChocolateCake();
            var kidCuisine = new KidCuisineFactory();

            kidCuisine.CreateDessert().Should().BeOfType(chocolateCakeDessert.GetType());
        }
    }
}
