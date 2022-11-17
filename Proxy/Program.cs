using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var libreriaDigital = new Biblioteca();
            string[] archivos =
            {
                "Libro1.pdf",
                "Libro2.pdf",
                "Libro3.pdf",
                "Libro4.pdf",
            };

            Console.WriteLine("LISTADO DE LIBROS");
            foreach (string archivo in archivos)
            {
                Console.WriteLine("\t" + archivo);
                IEBook libro = new EBookProxyLogging(archivo);
                libreriaDigital.Agregar(libro);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("El usuario hizo doble click en el libro 3");
            libreriaDigital.AbrirLibro("Libro3.pdf");
            Console.WriteLine();
            Console.WriteLine("El usuario hizo doble click en el libro 1");
            libreriaDigital.AbrirLibro("Libro1.pdf");

            Console.ReadLine();
        }
    }
}
