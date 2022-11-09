using System;

namespace Flyweight
{
    internal class Punto
    {
        private int x; // 4 bytes
        private int y; // 4 bytes
        IconoPunto iconoPunto;

        public Punto(int x, int y, IconoPunto iconoPunto)
        {
            this.x = x;
            this.y = y;
            this.iconoPunto = iconoPunto;
        }

        public void Dibujar()
        {
            Console.WriteLine($"{iconoPunto.Tipo} en las coordenadas ({x},{y})");
        }
    }
}
