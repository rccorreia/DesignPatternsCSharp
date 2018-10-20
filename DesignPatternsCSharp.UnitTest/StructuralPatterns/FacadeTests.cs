using FluentAssertions;
using NUnit.Framework;
using DesignPatternsCSharp.StructuralPatterns;
using System.Linq;

namespace DesignPatternsCSharp.UnitTest.StructuralPatterns
{
    [TestFixture]
    public class FacadeTests
    {
        [Test]
        public void ShouldCreateAnOrderWithAColdOptionWhenPatronOnlyDesiresColdOption()
        {
            var server = new Server();
            var patron = new Patron("Ricardo");
            const int peanutButterJellyId = 1;
            var peanutButterJelly = new PeanutButterJelly();

            var order = server.PlaceOrder(patron, coldAppId: peanutButterJellyId);

            order.Appetizer.First().Should().BeOfType(peanutButterJelly.GetType(), "It was an Peanut Butter Jelly order only.");
            order.Entree.Count().Should().Be(0, "No Entree requested.");
            order.Drink.Count().Should().Be(0, "No Drink requested.");
        }

        //ToDo Criar todas as outras opções
    }
}
