using System;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var controlador = new ControladorProductos();
            controlador.ListarProductos();

            Console.ReadLine();
        }
    }
}
