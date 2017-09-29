using System.Collections.Generic;

namespace PadrõesDeProjeto.PadrõesCriacionais.FactoryMethod
{
    public class FactoryMethod
    {
    }

    public abstract class Ingrediente { };

    public class Pão : Ingrediente { };

    public class Salsicha : Ingrediente { };

    public class Queijo : Ingrediente { };

    public class Presunto : Ingrediente { };

    public class Tomate : Ingrediente { };

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
