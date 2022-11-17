using System;

namespace Proxy
{
    internal class EBookProxyLogging : IEBook
    {
        private readonly string nombreArchivo;
        private EBook eBook;

        public string NombreArchivo => nombreArchivo;

        public EBookProxyLogging(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            eBook = new EBook(nombreArchivo);
        }

        public void Mostrar()
        {
            Console.WriteLine($"Guardamos el log del archivo {nombreArchivo} antes de su ejecucion");
            eBook.Mostrar();
            Console.WriteLine($"Guardamos el log del archivo {nombreArchivo} despues de su ejecucion");
        }
    }
}
