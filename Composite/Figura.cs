using System;

namespace Composite
{
    internal class Figura : IComponente
    {
        public void Dibujar()
        {
            Console.WriteLine("Dibujando la figura ...");
        }

        public void Mover()
        {
            Console.WriteLine("Moviendo la figura ...");
        }
    }
}
