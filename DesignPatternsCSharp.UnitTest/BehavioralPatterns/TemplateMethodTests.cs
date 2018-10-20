using FluentAssertions;
using DesignPatterns.BehavioralPatterns;
using NUnit.Framework;

namespace DesignPatternsCSharp.UnitTest.BehavioralPatterns
{
    [TestFixture]
    public class TemplateMethodTests
    {
        [Test]
        public void ShouldReturnActionsOfMakeMethodWhenTwelveGrainBread()
        {
            TwelveGrain twelveGrain = new TwelveGrain();
            var makeTwelveGrain = twelveGrain.Make();
            var expectedReturn = "Gathering Ingredients for 12-Grain Bread.Baking the 12-Grain Bread. (25 minutes).Slicing the TwelveGrain bread!";

            makeTwelveGrain.Should().Be(expectedReturn);
        }

        [Test]
        public void ShouldReturnActionsOfMakeMethodWhenSourdoughBread()
        {
            Sourdough sourdough = new Sourdough();
            var makeSourdough = sourdough.Make();
            var expectedReturn = "Gathering Ingredients for Sourdough Bread.Baking the Sourdough Bread. (20 minutes).Slicing the Sourdough bread!";

            makeSourdough.Should().Be(expectedReturn);
        }

        [Test]
        public void ShouldReturnActionsOfMakeMethodWhenWholeWheatBread()
        {
            WholeWheat wholeWheat = new WholeWheat();
            var makeWholeWheat = wholeWheat.Make();
            var expectedReturn = "Gathering Ingredients for Whole Wheat Bread.Baking the Whole Wheat Bread. (15 minutes).Slicing the WholeWheat bread!";

            makeWholeWheat.Should().Be(expectedReturn);
        }
    }
}
