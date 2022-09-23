using System;

namespace Strategy.BlogFotos
{
    internal class FiltroBlancoYNegro : IFiltro
    {
        public void Aplicar()
        {
            Console.WriteLine("Ejecutamos el algoritmo para aplicar el filtro Blanco y negro");
        }
    }
}
