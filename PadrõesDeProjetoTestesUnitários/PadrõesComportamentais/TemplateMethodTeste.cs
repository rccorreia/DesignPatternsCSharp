using FluentAssertions;
using PadrõesDeProjeto.PadrõesComportamentais;
using Xunit;

namespace PadrõesDeProjetoTestesUnitários.PadrõesComportamentais
{
    public class TemplateMethodTeste
    {
        [Fact]
        public void DeveRetornarAsAçõesRealizadasNoMétodoProduzirQuandoProduzirOPãoFrancês()
        {
            PãoFrancês pãoFrancês = new PãoFrancês();
            var retornoDoMétodoProduzir = pãoFrancês.Produzir();
            var retornoEsperado = "Misturando ingredientes para o pão francês.Cozinhando o pão francês. (15 minutos)Cortando o pão do tipo PãoFrancês.";

            retornoDoMétodoProduzir.Should().BeEquivalentTo(retornoEsperado);
        }
    }
}
