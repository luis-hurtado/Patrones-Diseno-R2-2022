using System;
using System.Runtime.CompilerServices;

namespace Flyweight.Ejercicio
{
    internal class FormatoCelda
    {

        public FormatoCelda(string fontFamily, int tamano, bool esNegrilla)
        {
            this.Fuente = fontFamily;
            this.Tamano = tamano;
            this.EsNegrilla = esNegrilla;
        }

        public string Fuente { get; set; }

        public int Tamano { get; set; }

        public bool EsNegrilla { get; set; }

        public override int GetHashCode()
        {
            return new { Fuente, Tamano, EsNegrilla }.GetHashCode();
        }
    }
}