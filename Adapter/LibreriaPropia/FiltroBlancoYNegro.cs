using System;

namespace Adapter.LibreriaPropia
{
    internal class FiltroBlancoYNegro : IFiltro
    {
        public void Aplicar(Imagen imagen)
        {
            Console.WriteLine($"Se aplico el filtro blanco y negro a la imagen {imagen.Nombre}");
        }
    }
}
