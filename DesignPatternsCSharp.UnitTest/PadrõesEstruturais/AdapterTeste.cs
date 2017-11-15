using FluentAssertions;
using PadrõesDeProjeto.PadrõesEstruturais.Adapter;
using PadrõesDeProjeto.PadrõesEstruturais.Adapter.LegacyAPI;
using Xunit;

namespace PadrõesDeProjetoTestesUnitários.PadrõesEstruturais
{
    public class AdapterTeste
    {
        [Fact]
        public void DeveCriarUmObjetoCarneComAsMesmasPropriedadesRetornadasPelaLegacyAPI()
        {
            var meatDatabase = new MeatDatabase();
            var carne = new Carne("Frango");

            var temperaturaDeCozimentoEmCelsius = meatDatabase.GetSafeCookTemp(carne.NomeNaLegacyAPI, TemperatureType.Celsius);
            var temperaturaDeCozimentoEmFahrenheit = meatDatabase.GetSafeCookTemp(carne.NomeNaLegacyAPI, TemperatureType.Fahrenheit);
            var caloriasPorGrama = meatDatabase.GetCaloriesPerOunce(carne.NomeNaLegacyAPI);
            var proteinaPorGrama = meatDatabase.GetProteinPerOunce(carne.NomeNaLegacyAPI);

            carne.CarregarInformaçõesDaCarne();

            carne.TemperaturaDeCozimentoEmCelsius.ShouldBeEquivalentTo(temperaturaDeCozimentoEmCelsius);
            carne.TemperaturaDeCozimentoEmFahrenheit.ShouldBeEquivalentTo(temperaturaDeCozimentoEmFahrenheit);
            carne.CaloriasPorGrama.ShouldBeEquivalentTo(caloriasPorGrama);
            carne.ProteinaPorGrama.ShouldBeEquivalentTo(proteinaPorGrama);
        }
    }
}
