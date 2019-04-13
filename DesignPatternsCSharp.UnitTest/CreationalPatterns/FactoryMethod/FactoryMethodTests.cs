using DesignPatternsCSharp.CreationalPatterns.FactoryMethod;
using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatternsCSharp.UnitTest.CreationalPatterns.FactoryMethod
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
        public void ShouldDisplayTheReadyMessageWithHotDogWhenTheCookMethodIsCalledAndTheCookingTimeIsGood()
        {
            var GoodCookingTimeForHotDogInSeconds = 360;
            var CookedMessage = $"Wait a minute, we are cooking your HotDog.\nThe Bread is ready\n" +
                $"The Sausage is ready\nThe PotatoSticks is ready\nThe Bread is ready\nYour Sandwich is ready.";

            var hotDog = new HotDog();
            hotDog.Cook(GoodCookingTimeForHotDogInSeconds).Should().Be(CookedMessage);
        }

        [Test]
        public void ShouldDisplayTheMessageWithAlertsForHotDogWhenTheCookMethodIsCalledAndTheCookingTimeIsNotGood()
        {
            var NotGoodCookingTimeForHotDogInSeconds = 1;
            var CookedMessage = $"Wait a minute, we are cooking your HotDog.\nOps, the Bread is not good\n" +
                $"Ops, the Sausage is not good\nOps, the PotatoSticks is not good\nOps, the Bread is not good\n" +
                $"Your Sandwich is ready.";

            var hotDog = new HotDog();
            hotDog.Cook(NotGoodCookingTimeForHotDogInSeconds).Should().Be(CookedMessage);
        }

        [Test]
        public void ShouldDisplayTheReadyMessageWithBrazilianBauruWhenTheCookMethodIsCalledAndTheCookingTimeIsGood()
        {
            var GoodCookingTimeForBrazilianBauruInSeconds = 360;
            var CookedMessage = $"Wait a minute, we are cooking your BrazilianBauru.\nThe Bread is ready\n" +
                $"The Cheese is ready\nThe Ham is ready\nThe Tomato is ready\nThe Bread is ready\nYour Sandwich is ready.";

            var brazilianBauru = new BrazilianBauru();
            brazilianBauru.Cook(GoodCookingTimeForBrazilianBauruInSeconds).Should().Be(CookedMessage);
        }

        [Test]
        public void ShouldDisplayTheMessageWithAlertsForBrazilianBauruWhenTheCookMethodIsCalledAndTheCookingTimeIsNotGood()
        {
            var NotGoodCookingTimeForBrazilianBauruInSeconds = 1;
            var CookedMessage = $"Wait a minute, we are cooking your BrazilianBauru.\nOps, the Bread is not good\n" +
                $"Ops, the Cheese is not good\nOps, the Ham is not good\nOps, the Tomato is not good\n" +
                $"Ops, the Bread is not good\nYour Sandwich is ready.";

            var brazilianBauru = new BrazilianBauru();
            brazilianBauru.Cook(NotGoodCookingTimeForBrazilianBauruInSeconds).Should().Be(CookedMessage);
        }

        [Test]
        public void ShouldDisplayTheIngredientListOfHotDogSandwich()
        {
            var HotDogIngredientList = "Bread Sausage PotatoSticks Bread";
            var hotDog = new HotDog();

            hotDog.IngredientsList().Should().Be(HotDogIngredientList);
        }

        [Test]
        public void ShouldDisplayTheIngredientListOfBrazilianBauruSandwich()
        {
            var BrazilianBauruIngredientList = "Bread Cheese Ham Tomato Bread";
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

        [Test]
        public void ShouldDisplayMessageOfNotCookedForBreadWhenCookingTimeUnderTheNecessary()
        {
            var bread = new Bread();
            var cookingTimeInSeconds = bread.CookingTime - 1;

            bread.Cook(cookingTimeInSeconds).Should().Be($"Ops, the {bread.IngredientName()} is not good");
        }

        [Test]
        public void ShouldDisplayMessageThatTheBreadIsReadyWhenCookingTimeEqualsTheNecessary()
        {
            var bread = new Bread();
            var cookingTimeInSeconds = bread.CookingTime;

            bread.Cook(cookingTimeInSeconds).Should().Be($"The {bread.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageThatTheBreadIsReadyWhenCookingTimeOverTheNecessary()
        {
            var bread = new Bread();
            var cookingTimeInSeconds = bread.CookingTime + 1;

            bread.Cook(cookingTimeInSeconds).Should().Be($"The {bread.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageOfNotCookedForSausageWhenCookingTimeUnderTheNecessary()
        {
            var sausage = new Sausage();
            var cookingTimeInSeconds = sausage.CookingTime - 1;

            sausage.Cook(cookingTimeInSeconds).Should().Be($"Ops, the {sausage.IngredientName()} is not good");
        }

        [Test]
        public void ShouldDisplayMessageThatTheSausageIsReadyWhenCookingTimeEqualsTheNecessary()
        {
            var sausage = new Sausage();
            var cookingTimeInSeconds = sausage.CookingTime;

            sausage.Cook(cookingTimeInSeconds).Should().Be($"The {sausage.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageThatTheSausageIsReadyWhenCookingTimeOverTheNecessary()
        {
            var sausage = new Sausage();
            var cookingTimeInSeconds = sausage.CookingTime + 1;

            sausage.Cook(cookingTimeInSeconds).Should().Be($"The {sausage.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageOfNotCookedForPotatoSticksWhenCookingTimeUnderTheNecessary()
        {
            var potatoSticks = new PotatoSticks();
            var cookingTimeInSeconds = potatoSticks.CookingTime - 1;

            potatoSticks.Cook(cookingTimeInSeconds).Should().Be($"Ops, the {potatoSticks.IngredientName()} is not good");
        }

        [Test]
        public void ShouldDisplayMessageThatThePotatoSticksIsReadyWhenCookingTimeEqualsTheNecessary()
        {
            var potatoSticks = new PotatoSticks();
            var cookingTimeInSeconds = potatoSticks.CookingTime;

            potatoSticks.Cook(cookingTimeInSeconds).Should().Be($"The {potatoSticks.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageThatThePotatoSticksIsReadyWhenCookingTimeOverTheNecessary()
        {
            var potatoSticks = new PotatoSticks();
            var cookingTimeInSeconds = potatoSticks.CookingTime + 1;

            potatoSticks.Cook(cookingTimeInSeconds).Should().Be($"The {potatoSticks.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageOfNotCookedForCheeseWhenCookingTimeUnderTheNecessary()
        {
            var cheese = new Cheese();
            var cookingTimeInSeconds = cheese.CookingTime - 1;

            cheese.Cook(cookingTimeInSeconds).Should().Be($"Ops, the {cheese.IngredientName()} is not good");
        }

        [Test]
        public void ShouldDisplayMessageThatTheCheeseIsReadyWhenCookingTimeEqualsTheNecessary()
        {
            var cheese = new Cheese();
            var cookingTimeInSeconds = cheese.CookingTime;

            cheese.Cook(cookingTimeInSeconds).Should().Be($"The {cheese.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageThatTheCheeseIsReadyWhenCookingTimeOverTheNecessary()
        {
            var cheese = new Cheese();
            var cookingTimeInSeconds = cheese.CookingTime + 1;

            cheese.Cook(cookingTimeInSeconds).Should().Be($"The {cheese.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageOfNotCookedForHamWhenCookingTimeUnderTheNecessary()
        {
            var ham = new Ham();
            var cookingTimeInSeconds = ham.CookingTime - 1;

            ham.Cook(cookingTimeInSeconds).Should().Be($"Ops, the {ham.IngredientName()} is not good");
        }

        [Test]
        public void ShouldDisplayMessageThatTheHamIsReadyWhenCookingTimeEqualsTheNecessary()
        {
            var ham = new Ham();
            var cookingTimeInSeconds = ham.CookingTime;

            ham.Cook(cookingTimeInSeconds).Should().Be($"The {ham.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageThatTheHamIsReadyWhenCookingTimeOverTheNecessary()
        {
            var ham = new Ham();
            var cookingTimeInSeconds = ham.CookingTime + 1;

            ham.Cook(cookingTimeInSeconds).Should().Be($"The {ham.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageOfNotCookedForTomatoWhenCookingTimeUnderTheNecessary()
        {
            var tomato = new Tomato();
            var cookingTimeInSeconds = tomato.CookingTime - 1;

            tomato.Cook(cookingTimeInSeconds).Should().Be($"Ops, the {tomato.IngredientName()} is not good");
        }

        [Test]
        public void ShouldDisplayMessageThatTheTomatoIsReadyWhenCookingTimeEqualsTheNecessary()
        {
            var tomato = new Tomato();
            var cookingTimeInSeconds = tomato.CookingTime;

            tomato.Cook(cookingTimeInSeconds).Should().Be($"The {tomato.IngredientName()} is ready");
        }

        [Test]
        public void ShouldDisplayMessageThatTheTomatoIsReadyWhenCookingTimeOverTheNecessary()
        {
            var tomato = new Tomato();
            var cookingTimeInSeconds = tomato.CookingTime + 1;

            tomato.Cook(cookingTimeInSeconds).Should().Be($"The {tomato.IngredientName()} is ready");
        }
    }
}
