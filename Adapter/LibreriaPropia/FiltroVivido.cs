using System;

namespace Adapter.LibreriaPropia
{
    internal class FiltroVivido : IFiltro
    {
        public void Aplicar(Imagen imagen)
        {
            Console.WriteLine($"Se aplico el filtro vivido a la imagen {imagen.Nombre}");
        }
    }
}
