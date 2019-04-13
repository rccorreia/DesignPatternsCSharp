using DesignPatternsCSharp.CreationalPatterns.FactoryMethod;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void ShouldCreateHotDogIngredientsWhenHotDogIsInstantiated()
        {
            var hotDogIngredients = new List<Ingredient>()
            {
                new Bread(),
                new Sausage(),
                new PotatoSticks(),
                new Bread()
            };
            var hotDog = new HotDog();

            hotDog.Ingredients[0].Should().BeOfType(hotDogIngredients[0].GetType());
            hotDog.Ingredients[1].Should().BeOfType(hotDogIngredients[1].GetType());
            hotDog.Ingredients[2].Should().BeOfType(hotDogIngredients[2].GetType());
            hotDog.Ingredients[3].Should().BeOfType(hotDogIngredients[3].GetType());
        }

        [Test]
        public void ShouldCreateBrazilianBauruIngredientsWhenBrazilianBauruIsInstantiated()
        {
            var brazilianBauruIngredients = new List<Ingredient>()
            {
                new Bread(),
                new Cheese(),
                new Ham(),
                new Tomato(),
                new Bread()
            };
            var brazilianBauru = new BrazilianBauru();

            brazilianBauru.Ingredients[0].Should().BeOfType(brazilianBauruIngredients[0].GetType());
            brazilianBauru.Ingredients[1].Should().BeOfType(brazilianBauruIngredients[1].GetType());
            brazilianBauru.Ingredients[2].Should().BeOfType(brazilianBauruIngredients[2].GetType());
            brazilianBauru.Ingredients[3].Should().BeOfType(brazilianBauruIngredients[3].GetType());
            brazilianBauru.Ingredients[4].Should().BeOfType(brazilianBauruIngredients[4].GetType());
        }

        [Test]
        public void ShouldDisplayTheReadyMessageWithHotDogNameWhenTheCookMethodIsCalled()
        {
            var hotDog = new HotDog();

            hotDog.Cook().Should().Be("The HotDog sandwich is ready");
        }

        [Test]
        public void ShouldDisplayTheReadyMessageWithTheBrazilianBauruNameWhenTheCookMethodIsCalled()
        {
            var brazilianBauru = new BrazilianBauru();

            brazilianBauru.Cook().Should().Be("The BrazilianBauru sandwich is ready");
        }

        [Test]
        public void ShouldDisplayTheIngredientListOfHotDogSandwich()
        {
            const string HotDogIngredientList = "Bread Sausage PotatoSticks Bread";
            var hotDog = new HotDog();

            hotDog.IngredientsList().Should().Be(HotDogIngredientList);
        }

        [Test]
        public void ShouldDisplayTheIngredientListOfBrazilianBauruSandwich()
        {
            const string BrazilianBauruIngredientList = "Bread Cheese Ham Tomato Bread";
            var brazilianBauru = new BrazilianBauru();

            brazilianBauru.IngredientsList().Should().Be(BrazilianBauruIngredientList);
        }

        [Test]
        public void ShouldCountTheCaloriesOfAHotDogSandwich()
        {
            const decimal HotDogCaloriesCount = 937.55M;
            var hotDog = new HotDog();

            hotDog.CaloriesCount().Should().Be(HotDogCaloriesCount);
        }

        [Test]
        public void ShouldCountTheCaloriesOfABrazilianBauruSandwich()
        {
            const decimal BrazilianBauruCaloriesCount = 799.26M;
            var brazilianBauru = new BrazilianBauru();

            brazilianBauru.CaloriesCount().Should().Be(BrazilianBauruCaloriesCount);
        }
    }
}
