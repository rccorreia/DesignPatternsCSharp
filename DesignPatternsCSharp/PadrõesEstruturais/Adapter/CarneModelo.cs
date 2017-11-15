using System;

namespace PadrõesDeProjeto.PadrõesEstruturais.Adapter
{
    public class CarneModelo
    {
        public string Nome;
        public string NomeNaLegacyAPI;
        public float TemperaturaDeCozimentoEmCelsius;
        public float TemperaturaDeCozimentoEmFahrenheit;
        public float CaloriasPorGrama;
        public float ProteinaPorGrama;

        public CarneModelo(string nome)
        {
            Nome = nome;
            NomeNaLegacyAPI = ModificaNomeParaEquivalenteNaLegacyAPI(nome);
        }

        private string ModificaNomeParaEquivalenteNaLegacyAPI(string nome)
        {
            switch (nome)
            {
                case "Frango":
                    return "chicken";
                default:
                    return "";
            }
        }

        public virtual void CarregarInformaçõesDaCarne() { }
    }
}
