using DesignPatternsCSharp.StructuralPatterns.Adapter.LegacyAPI;

namespace DesignPatternsCSharp.StructuralPatterns.Adapter
{
    public class MeatDetails : Meat
    {
        private MeatDatabase _meatDatabase;

        public MeatDetails(string name)
            : base(name) { }

        public override void LoadData()
        {
            _meatDatabase = new MeatDatabase();
            SafeCookTempFahrenheit = _meatDatabase.GetSafeCookTemp(MeatName,
            TemperatureType.Fahrenheit);
            SafeCookTempCelsius = _meatDatabase.GetSafeCookTemp(MeatName,
            TemperatureType.Celsius);
            CaloriesPerOunce = _meatDatabase.GetCaloriesPerOunce(MeatName);
            ProteinPerOunce = _meatDatabase.GetProteinPerOunce(MeatName);
        }
    }
}
