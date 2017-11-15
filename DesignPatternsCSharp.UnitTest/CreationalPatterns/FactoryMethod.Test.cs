using DesignPatternsCSharp.CreationalPatterns.FactoryMethod;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns
{
    public class FactoryMethodTest
    {
        [Fact]
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

            hotDog.Ingredients.ShouldBeEquivalentTo(hotDogIngredients);
        }

        [Fact]
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

            brazilianBauru.Ingredients.ShouldBeEquivalentTo(brazilianBauruIngredients);
        }
    }
}
