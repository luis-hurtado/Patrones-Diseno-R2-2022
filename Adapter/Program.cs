using Adapter.LibreriaPropia;
using Adapter.LibreriaTerceros;
using Adapter.OtraLibreriaTerceros;

using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var visor = new VisorImagen(new Imagen("imagen1.jpg"));
            visor.btnAplicarFiltroClick(new FiltroVivido());
            visor.btnAplicarFiltroClick(new FiltroBlancoYNegro());
            //Aplicar el filtro de terceros
            visor.btnAplicarFiltroClick(new Adaptador.AdaptadorFiltroTerceros(new FiltroAzul()));
            visor.btnAplicarFiltroClick(new Adaptador.AdaptadorFiltroTerceros(new FiltroVerde()));
            visor.btnAplicarFiltroClick(new Adaptador.AdaptadorFiltroTerceros(new FiltroRojo()));
            visor.btnAplicarFiltroClick(new Adaptador.AdaptadorFiltroTerceros(new FiltroSepia()));
            //Aplicar Otro filtro de terceros
            visor.btnAplicarFiltroClick(new Adaptador.AdaptadorFiltroOtros(new FiltroContraste()));
            // Aplicar filtro contraste por herencia
            visor.btnAplicarFiltroClick(new Adaptador.AdaptadorPorHerencia());


            Console.ReadLine();
        }
    }
}
