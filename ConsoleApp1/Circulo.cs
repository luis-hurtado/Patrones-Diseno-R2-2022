using System;

namespace Prototype
{
    internal class Circulo : IComponente
    {
        public int Radio { get; set; }
        public ConsoleColor Color { get; set; }

        public IComponente Clonar()
        {
            return new Circulo
            {
                Color = Color,
                Radio = Radio,
            };

        }

        public void Renderizar()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Se dibujo un circulo con radio {Radio}");
            Console.ResetColor();
        }
    }
}
