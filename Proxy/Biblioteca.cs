using System.Collections.Generic;

namespace Proxy
{
    internal class Biblioteca
    {
        private readonly Dictionary<string, IEBook> libros = new Dictionary<string, IEBook>();

        public void Agregar(IEBook libro)
        {
            libros[libro.NombreArchivo] = libro;
        }

        public void AbrirLibro(string nombreArchivo)
        {
            libros[nombreArchivo]?.Mostrar();
        }
    }
}
