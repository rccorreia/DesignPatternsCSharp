using DesignPatternsCSharp.StructuralPatterns;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatternsCSharp.UnitTest.StructuralPatterns
{
    [TestFixture]
    public class BridgeTests
    {
        [Test]
        public void ShouldReturnRightMessageWhenOrderingDairyFreeAtTheDiner()
        {
            var returnMessage = "Placing order for Dairy-Free Order at the Diner.";

            SendOrder sendOrder = new SendDairyFreeOrder
            {
                restaurant = new DinerOrders()
            };
            var message = sendOrder.Send();

            message.Should().Be(returnMessage);
        }

        [Test]
        public void ShouldReturnRightMessageWhenOrderingGlutenFreeAtTheDiner()
        {
            var returnMessage = "Placing order for Gluten-Free Order at the Diner.";

            SendOrder sendOrder = new SendGlutenFreeOrder
            {
                restaurant = new DinerOrders()
            };
            var message = sendOrder.Send();

            message.Should().Be(returnMessage);
        }
        [Test]
        public void ShouldReturnRightMessageWhenOrderingDairyFreeAtTheFancyRestaurant()
        {
            var returnMessage = "Placing order for Dairy-Free Order at the Fancy Restaurant.";

            SendOrder sendOrder = new SendDairyFreeOrder
            {
                restaurant = new FancyRestaurantOrders()
            };
            var message = sendOrder.Send();

            message.Should().Be(returnMessage);
        }

        [Test]
        public void ShouldReturnRightMessageWhenOrderingGlutenFreeAtTheFancyRestaurant()
        {
            var returnMessage = "Placing order for Gluten-Free Order at the Fancy Restaurant.";

            SendOrder sendOrder = new SendGlutenFreeOrder
            {
                restaurant = new FancyRestaurantOrders()
            };
            var message = sendOrder.Send();

            message.Should().Be(returnMessage);
        }
    }
}
