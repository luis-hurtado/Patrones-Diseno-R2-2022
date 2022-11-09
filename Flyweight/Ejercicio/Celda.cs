using System;

namespace Flyweight.Ejercicio
{
    internal class Celda
    {
        private string fila;
        private string columna;
        private string contenido;
        private FormatoCelda formato;

        public Celda(string fila, string columna, FormatoCelda formato)
        {
            this.fila = fila;
            this.columna = columna;
            this.formato = formato;
        }

        public string Contenido { get => contenido; set => contenido = value; }
        public FormatoCelda Formato { get => formato; set => formato = value; }

        public void MostrarCelda()
        {
            Console.WriteLine($"Celda({columna}{fila}): {contenido} - Formato ({formato.Fuente}, {formato.Tamano} - {VerNegrilla(formato.EsNegrilla)})");
        }

        private object VerNegrilla(bool esNegrilla)
        {
            return esNegrilla ? "Negrilla" : "Normal";
        }
    }
}
