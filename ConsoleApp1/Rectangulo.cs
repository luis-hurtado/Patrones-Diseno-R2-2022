using System;

namespace Prototype
{
    internal class Rectangulo : IComponente
    {
        public ConsoleColor Color { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int Id { get; }

        private static int semilla = 0;

        public Rectangulo()
        {
            Id = semilla++;
        }

        public IComponente Clonar()
        {
            return new Rectangulo
            {
                Alto = Alto,
                Ancho = Ancho,
                Color = Color,
            };
        }

        public void Renderizar()
        {
            string figura = (Alto == Ancho) ? "Cuadrado" : "Rectangulo";
            Console.ForegroundColor = Color;
            Console.WriteLine($"Se dibujo un {figura} con id={Id} (Alto:{Alto} y Ancho:{Ancho})");
            Console.ResetColor();
        }
    }
}
