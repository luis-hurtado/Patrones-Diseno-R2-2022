using System;

namespace Proxy
{
    internal class EBook : IEBook
    {
        private readonly string nombreArchivo;

        public string NombreArchivo { get => nombreArchivo; }

        public EBook(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            Cargar();
        }

        private void Cargar()
        {
            Console.WriteLine("Cargando el archivo: " + nombreArchivo);
        }

        public void Mostrar()
        {
            Console.WriteLine("Mostrando el libro correspondiente al archivo: " + nombreArchivo);
        }
    }
}
