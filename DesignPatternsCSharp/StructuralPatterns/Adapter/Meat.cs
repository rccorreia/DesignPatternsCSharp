namespace DesignPatternsCSharp.StructuralPatterns.Adapter
{
    public class Meat
    {
        public string MeatName;
        public float SafeCookTempFahrenheit;
        public float SafeCookTempCelsius;
        public double CaloriesPerOunce;
        public double ProteinPerOunce;

        public Meat(string meat)
        {
            MeatName = meat;
        }

        public virtual void LoadData() { }
    }
}
