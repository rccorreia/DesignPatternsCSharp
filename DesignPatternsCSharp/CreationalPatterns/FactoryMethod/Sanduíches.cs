using System.Collections.Generic;

namespace DesignPatternsCSharp.CreationalPatterns.FactoryMethod
{
    public abstract class Sanduíche
    {
        private List<Ingrediente> _ingredientes = new List<Ingrediente>();

        public Sanduíche()
        {
            CriarIngredientes();
        }

        public abstract void CriarIngredientes();

        public List<Ingrediente> Ingredientes
        {
            get { return _ingredientes; }
        }
    }

    public class CachorroQuente : Sanduíche
    {
        public override void CriarIngredientes()
        {
            Ingredientes.Add(new Pão());
            Ingredientes.Add(new Salsicha());
            Ingredientes.Add(new BatataPalha());
            Ingredientes.Add(new Pão());
        }
    }

    public class Bauru : Sanduíche
    {
        public override void CriarIngredientes()
        {
            Ingredientes.Add(new Pão());
            Ingredientes.Add(new Queijo());
            Ingredientes.Add(new Presunto());
            Ingredientes.Add(new Tomate());
            Ingredientes.Add(new Pão());
        }
    }
}
