using System;

namespace Strategy.BlogFotos
{
    internal class FiltroAltoContraste : IFiltro
    {
        public void Aplicar()
        {
            Console.WriteLine("Ejecutamos el algoritmo para aplicar el filtro de Alto Contraste");
        }
    }
}
