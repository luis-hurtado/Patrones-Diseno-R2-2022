using System;

namespace Visitor
{
    internal class OperacionResaltar : IOperacion
    {
        public void Ejecutar(NodoAncla ancla)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<a> Resaltatando el nodo Ancla .. </a>");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Ejecutar(NodoCabecera cabecera)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("<h1> Resaltatando el nodo cabecera .. </h1>");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Ejecutar(NodoImagen imagen)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("<img> mostrando la imagen </img>");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
