using Prototype;
using Prototype.Ejercicio;

using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo();
            Test.Ejecutar();

            Console.ReadLine();
        }

        private static void Demo()
        {
            MenuContextual menuContextual = new MenuContextual();
            Circulo circuloBase = new Circulo
            {
                Color = ConsoleColor.Blue,
                Radio = 10
            };
            circuloBase.Renderizar();

            Console.WriteLine();

            var clon = menuContextual.Duplicar(circuloBase);
            clon.Renderizar();

            circuloBase.Color = ConsoleColor.Green;
            ((Circulo)clon).Radio = 3;

            Console.WriteLine();
            Console.WriteLine();
            circuloBase.Renderizar();
            Console.WriteLine();
            clon.Renderizar();

            Console.WriteLine("/****************************************************************************************************/");
            Rectangulo cuadrado = new Rectangulo
            {
                Color = ConsoleColor.Blue,
                Alto = 10,
                Ancho = 10
            };
            cuadrado.Renderizar();

            Console.WriteLine();

            var rectanguloClon1 = menuContextual.Duplicar(cuadrado);
            rectanguloClon1.Renderizar();
            var rectanguloClon2 = menuContextual.Duplicar(cuadrado);
            rectanguloClon2.Renderizar();

            Console.WriteLine();
            Console.WriteLine();
            ((Rectangulo)rectanguloClon1).Ancho = 20;
            ((Rectangulo)rectanguloClon2).Color = ConsoleColor.Red;
            cuadrado.Renderizar();
            rectanguloClon1.Renderizar();
            rectanguloClon2.Renderizar();
        }
    }
}
