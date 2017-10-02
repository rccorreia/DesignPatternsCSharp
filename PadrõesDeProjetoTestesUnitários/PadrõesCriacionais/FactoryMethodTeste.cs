using FluentAssertions;
using PadrõesDeProjeto.PadrõesCriacionais.FactoryMethod;
using System.Collections.Generic;
using Xunit;

namespace PadrõesDeProjetoTestesUnitários.PadrõesCriacionais
{
    public class FactoryMethodTeste
    {
        [Fact]
        public void DeveCriarOsIngredientesPãoSalsichaPãoQuandoOObjetoCachorroQuenteÉCriado()
        {
            var ingredientesDoCachorroQuente = new List<Ingrediente>()
            {
                new Pão(),
                new Salsicha(),
                new BatataPalha(),
                new Pão()
            };

            var cachorroQuente = new CachorroQuente();

            cachorroQuente.Ingredientes.ShouldBeEquivalentTo(ingredientesDoCachorroQuente);
        }

        [Fact]
        public void DeveCriarOsIngredientesPãoQueijoPresuntoTomatePãoQuandoOObjetoBauruÉCriado()
        {
            var ingredientesDoBauru = new List<Ingrediente>()
            {
                new Pão(),
                new Queijo(),
                new Presunto(),
                new Tomate(),
                new Pão()
            };

            var bauru = new Bauru();
            
            bauru.Ingredientes.ShouldBeEquivalentTo(ingredientesDoBauru);
        }
    }
}
