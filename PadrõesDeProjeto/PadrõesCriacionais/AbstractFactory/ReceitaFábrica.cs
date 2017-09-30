namespace PadrõesDeProjeto.PadrõesCriacionais.AbstractFactory
{
    public abstract class ReceitaFábrica
    {
        public abstract Refeição CriarRefeição();
        public abstract Sobremesa CriarSobremesa();
    }

    public class CardápioAdultoFábrica : ReceitaFábrica
    {
        public override Refeição CriarRefeição()
        {
            return new Espaguete();
        }

        public override Sobremesa CriarSobremesa()
        {
            return new TortaHolandesa();
        }
    }

    public class CardápioInfantilFábrica : ReceitaFábrica
    {
        public override Refeição CriarRefeição()
        {
            return new ArrozComBrócolis();
        }

        public override Sobremesa CriarSobremesa()
        {
            return new BoloDeChocolate();
        }
    }
}
