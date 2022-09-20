using System;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lienzo lienzo = new Lienzo();

            lienzo.TipoHerramientaActual = new HerramientaPincel();
            Console.WriteLine($"El tipo de herramienta seleccionada es {TipoHerramienta.Pincel}");
            lienzo.MouseDown();
            lienzo.MouseUp();
            Console.WriteLine();

            lienzo.TipoHerramientaActual = new HerramientaSeleccion();
            Console.WriteLine($"El tipo de herramienta seleccionada es {TipoHerramienta.Seleccion}");
            lienzo.MouseDown();
            lienzo.MouseUp();
            Console.WriteLine();

            lienzo.TipoHerramientaActual = new HerramientaBorrador();
            Console.WriteLine($"El tipo de herramienta seleccionada es {TipoHerramienta.Borrador}");
            lienzo.MouseDown();
            lienzo.MouseUp();
            Console.WriteLine();

            lienzo.TipoHerramientaActual = new HerramientaClonado();
            Console.WriteLine($"El tipo de herramienta seleccionada es Clonado");
            lienzo.MouseDown();
            lienzo.MouseUp();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
