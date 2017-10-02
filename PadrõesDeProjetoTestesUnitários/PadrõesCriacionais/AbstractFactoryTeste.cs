using FluentAssertions;
using Xunit;
using PadrõesDeProjeto.PadrõesCriacionais.AbstractFactory;

namespace PadrõesDeProjetoTestesUnitários.PadrõesCriacionais
{
    public class AbstractFactoryTeste
    {
        [Fact]
        public void DeveCriarARefeiçãoEspagueteQuandoOMétodoCriarRefeiçãoDoCardápioAdultoÉUtilizado()
        {
            var refeiçãoEspaguete = new Espaguete();

            var cardápioAdulto = new CardápioAdultoFábrica();

            cardápioAdulto.CriarRefeição().Should().BeOfType(refeiçãoEspaguete.GetType());
        }

        [Fact]
        public void DeveCriarASobremesaTortaHolandesaQuandoOMétodoCriarSobremesaDoCardápioAdultoÉUtilizado()
        {
            var sobremesaTortaHolandesa = new TortaHolandesa();

            var cardápioAdulto = new CardápioAdultoFábrica();

            cardápioAdulto.CriarSobremesa().Should().BeOfType(sobremesaTortaHolandesa.GetType());
        }

        [Fact]
        public void DeveCriarARefeiçãoArrozComBrócolisQuandoOMétodoCriarRefeiçãoDoCardápioinfantilÉUtilizado()
        {
            var refeiçãoArrozComBrócolis = new ArrozComBrócolis();

            var cardápioInfantil = new CardápioInfantilFábrica();

            cardápioInfantil.CriarRefeição().Should().BeOfType(refeiçãoArrozComBrócolis.GetType());
        }

        [Fact]
        public void DeveCriarASobremesaBoloDeChocolateQuandoOMétodoCriarSobremesaDoCardápioinfantilÉUtilizado()
        {
            var sobremesaBoloDeChocolate = new BoloDeChocolate();

            var cardápioInfantil = new CardápioInfantilFábrica();

            cardápioInfantil.CriarSobremesa().Should().BeOfType(sobremesaBoloDeChocolate.GetType());
        }
    }
}
