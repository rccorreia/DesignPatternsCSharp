using PadrõesDeProjeto.PadrõesEstruturais.Adapter.LegacyAPI;
using System;

namespace PadrõesDeProjeto.PadrõesEstruturais.Adapter
{
    public class Carne : CarneModelo
    {
        private MeatDatabase _meatDatabase;

        public Carne(string nome) 
            : base(nome) { }

        public override void CarregarInformaçõesDaCarne()
        {
            _meatDatabase = new MeatDatabase();
            TemperaturaDeCozimentoEmCelsius = _meatDatabase.GetSafeCookTemp(NomeNaLegacyAPI,
            TemperatureType.Celsius);
            TemperaturaDeCozimentoEmFahrenheit = _meatDatabase.GetSafeCookTemp(NomeNaLegacyAPI,
            TemperatureType.Fahrenheit);
            CaloriasPorGrama = _meatDatabase.GetCaloriesPerOunce(NomeNaLegacyAPI);
            ProteinaPorGrama = _meatDatabase.GetProteinPerOunce(NomeNaLegacyAPI);
        }
    }
}
