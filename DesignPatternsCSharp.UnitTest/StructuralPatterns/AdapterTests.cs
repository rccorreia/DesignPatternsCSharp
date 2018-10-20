using FluentAssertions;
using NUnit.Framework;
using DesignPatternsCSharp.StructuralPatterns.Adapter;
using DesignPatternsCSharp.StructuralPatterns.Adapter.LegacyAPI;

namespace DesignPatternsCSharp.UnitTest.StructuralPatterns
{
    [TestFixture]
    public class AdapterTests
    {
        //[Test]
        //public void ShouldCreateABeefMeatDetails()
        //{
        //    var beef = new MeatDetails("Beef");

        //    var meatDatabase = new MeatDatabase();
        //    var beefSafeCookTempCelsius = meatDatabase.GetSafeCookTemp(beef.MeatName, TemperatureType.Celsius);
        //    var beefSafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(beef.MeatName, TemperatureType.Fahrenheit);
        //    var beefCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(beef.MeatName);
        //    var beefProteinPerOunce = meatDatabase.GetProteinPerOunce(beef.MeatName);

        //    beef.LoadData();

        //    beef.SafeCookTempCelsius.Should().Be(beefSafeCookTempCelsius);
        //    beef.SafeCookTempFahrenheit.Should().Be(beefSafeCookTempFahrenheit);
        //    beef.CaloriesPerOunce.Should().Be(beefCaloriesPerOunce);
        //    beef.ProteinPerOunce.Should().Be(beefProteinPerOunce);
        //}

        //[Test]
        //public void ShouldCreateAPorkMeatDetails()
        //{
        //    var pork = new MeatDetails("Pork");

        //    var meatDatabase = new MeatDatabase();
        //    var porkSafeCookTempCelsius = meatDatabase.GetSafeCookTemp(pork.MeatName, TemperatureType.Celsius);
        //    var porkSafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(pork.MeatName, TemperatureType.Fahrenheit);
        //    var porkCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(pork.MeatName);
        //    var porkProteinPerOunce = meatDatabase.GetProteinPerOunce(pork.MeatName);

        //    pork.LoadData();

        //    pork.SafeCookTempCelsius.Should().Be(porkSafeCookTempCelsius);
        //    pork.SafeCookTempFahrenheit.Should().Be(porkSafeCookTempFahrenheit);
        //    pork.CaloriesPerOunce.Should().Be(porkCaloriesPerOunce);
        //    pork.ProteinPerOunce.Should().Be(porkProteinPerOunce);
        //}

        //[Test]
        //public void ShouldCreateAChickenMeatDetails()
        //{
        //    var chicken = new MeatDetails("Chicken");

        //    var meatDatabase = new MeatDatabase();
        //    var chickenSafeCookTempCelsius = meatDatabase.GetSafeCookTemp(chicken.MeatName, TemperatureType.Celsius);
        //    var chickenSafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(chicken.MeatName, TemperatureType.Fahrenheit);
        //    var chickenCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(chicken.MeatName);
        //    var chickenProteinPerOunce = meatDatabase.GetProteinPerOunce(chicken.MeatName);

        //    chicken.LoadData();

        //    chicken.SafeCookTempCelsius.Should().Be(chickenSafeCookTempCelsius);
        //    chicken.SafeCookTempFahrenheit.Should().Be(chickenSafeCookTempFahrenheit);
        //    chicken.CaloriesPerOunce.Should().Be(chickenCaloriesPerOunce);
        //    chicken.ProteinPerOunce.Should().Be(chickenProteinPerOunce);
        //}

        //[Test]
        //public void ShouldCreateATurkeyMeatDetails()
        //{
        //    var turkey = new MeatDetails("Turkey");

        //    var meatDatabase = new MeatDatabase();
        //    var turkeySafeCookTempCelsius = meatDatabase.GetSafeCookTemp(turkey.MeatName, TemperatureType.Celsius);
        //    var turkeySafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(turkey.MeatName, TemperatureType.Fahrenheit);
        //    var turkeyCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(turkey.MeatName);
        //    var turkeyProteinPerOunce = meatDatabase.GetProteinPerOunce(turkey.MeatName);

        //    turkey.LoadData();

        //    turkey.SafeCookTempCelsius.Should().Be(turkeySafeCookTempCelsius);
        //    turkey.SafeCookTempFahrenheit.Should().Be(turkeySafeCookTempFahrenheit);
        //    turkey.CaloriesPerOunce.Should().Be(turkeyCaloriesPerOunce);
        //    turkey.ProteinPerOunce.Should().Be(turkeyProteinPerOunce);
        //}

        //[Test]
        //public void ShouldCreateAVealMeatDetails()
        //{
        //    var veal = new MeatDetails("Veal");

        //    var meatDatabase = new MeatDatabase();
        //    var vealSafeCookTempCelsius = meatDatabase.GetSafeCookTemp(veal.MeatName, TemperatureType.Celsius);
        //    var vealSafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(veal.MeatName, TemperatureType.Fahrenheit);
        //    var vealCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(veal.MeatName);
        //    var vealProteinPerOunce = meatDatabase.GetProteinPerOunce(veal.MeatName);

        //    veal.LoadData();

        //    veal.SafeCookTempCelsius.Should().Be(vealSafeCookTempCelsius);
        //    veal.SafeCookTempFahrenheit.Should().Be(vealSafeCookTempFahrenheit);
        //    veal.CaloriesPerOunce.Should().Be(vealCaloriesPerOunce);
        //    veal.ProteinPerOunce.Should().Be(vealProteinPerOunce);
        //}

        //[Test]
        //public void ShouldCreateAnAnotherMeatMeatDetails()
        //{
        //    var anotherMeat = new MeatDetails("AnotherMeat");

        //    var meatDatabase = new MeatDatabase();
        //    var anotherMeatSafeCookTempCelsius = meatDatabase.GetSafeCookTemp(anotherMeat.MeatName, TemperatureType.Celsius);
        //    var anotherMeatSafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(anotherMeat.MeatName, TemperatureType.Fahrenheit);
        //    var anotherMeatCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(anotherMeat.MeatName);
        //    var anotherMeatProteinPerOunce = meatDatabase.GetProteinPerOunce(anotherMeat.MeatName);

        //    anotherMeat.LoadData();

        //    anotherMeat.SafeCookTempCelsius.Should().Be(anotherMeatSafeCookTempCelsius);
        //    anotherMeat.SafeCookTempFahrenheit.Should().Be(anotherMeatSafeCookTempFahrenheit);
        //    anotherMeat.CaloriesPerOunce.Should().Be(anotherMeatCaloriesPerOunce);
        //    anotherMeat.ProteinPerOunce.Should().Be(anotherMeatProteinPerOunce);
        //}


        [TestCase("Beef")]
        [TestCase("Pork")]
        [TestCase("Chicken")]
        [TestCase("Turkey")]
        [TestCase("Veal")]
        [TestCase("AnotherMeat")]
        public void ShouldCreateAnAnotherMeatMeatDetails(string meatName)
        {
            var meatDetails = new MeatDetails(meatName);

            var meatDatabase = new MeatDatabase();
            var meatDetailsSafeCookTempCelsius = meatDatabase.GetSafeCookTemp(meatDetails.MeatName, TemperatureType.Celsius);
            var meatDetailsSafeCookTempFahrenheit = meatDatabase.GetSafeCookTemp(meatDetails.MeatName, TemperatureType.Fahrenheit);
            var meatDetailsCaloriesPerOunce = meatDatabase.GetCaloriesPerOunce(meatDetails.MeatName);
            var meatDetailsProteinPerOunce = meatDatabase.GetProteinPerOunce(meatDetails.MeatName);

            meatDetails.LoadData();

            meatDetails.SafeCookTempCelsius.Should().Be(meatDetailsSafeCookTempCelsius);
            meatDetails.SafeCookTempFahrenheit.Should().Be(meatDetailsSafeCookTempFahrenheit);
            meatDetails.CaloriesPerOunce.Should().Be(meatDetailsCaloriesPerOunce);
            meatDetails.ProteinPerOunce.Should().Be(meatDetailsProteinPerOunce);
        }
    }
}
