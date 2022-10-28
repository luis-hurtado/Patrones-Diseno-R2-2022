using System.Collections.Generic;

namespace Composite
{
    internal class Grupo : IComponente
    {
        readonly List<IComponente> elementos = new List<IComponente>();

        public void Agregar(IComponente elemento)
        {
            elementos.Add(elemento);
        }

        public void Dibujar()
        {
            foreach (IComponente elemento in elementos)
            {
                elemento.Dibujar();
            }
        }

        public void Mover()
        {
            foreach (IComponente elemento in elementos)
            {
                elemento.Mover();
            }
        }
    }
}
