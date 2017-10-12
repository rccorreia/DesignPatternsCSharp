using System.Text;

namespace PadrõesDeProjeto.PadrõesComportamentais
{
    class TemplateMethod
    {
    }

    public abstract class Pão
    {
        protected abstract string MisturarIngredientes();

        protected abstract string Cozinhar();

        protected virtual string Cortar()
        {
            return ("Cortando o pão do tipo " + GetType().Name + ".");
        }

        public string Produzir()
        {
            StringBuilder retornoDasAções = new StringBuilder();

            retornoDasAções.Append(MisturarIngredientes());
            retornoDasAções.Append(Cozinhar());
            retornoDasAções.Append(Cortar());

            return retornoDasAções.ToString();
        }
    }

    public class VinteGrãos : Pão
    {
        protected override string MisturarIngredientes() => "Misturando ingredientes para o pão de vinte grãos.";
        protected override string Cozinhar() => "Cozinhando o pão de vinte grãos. (25 minutos)";
    }

    public class PãoDeForma : Pão
    {
        protected override string MisturarIngredientes() => "Misturando ingredientes para o pão de forma.";
        protected override string Cozinhar() => "Cozinhando o pão de forma. (20 minutos)";
    }

    public class PãoFrancês : Pão
    {
        protected override string MisturarIngredientes() => "Misturando ingredientes para o pão francês.";
        protected override string Cozinhar() => "Cozinhando o pão francês. (15 minutos)";
    }
}
