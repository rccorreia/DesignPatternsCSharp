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

            hotDog.Ingredients.Should().ContainInOrder(hotDogIngredients);
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

            brazilianBauru.Ingredients.Should().ContainInOrder(brazilianBauruIngredients);
        }
    }
}
