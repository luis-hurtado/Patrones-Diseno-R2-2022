using System;

namespace Adapter.LibreriaTerceros
{
    internal class FiltroSepia : IFiltroTerceros
    {
        string filtro;

        public void Inicializar()
        {
            filtro = "Aplicando el filtro de terceros (Sepia) a la imagen";
        }

        public void UsarFiltro(Imagen imagen)
        {
            Console.WriteLine(filtro);
            Console.WriteLine(imagen.Nombre);
            Console.WriteLine("Fin proceso filtro por terceros");
        }
    }
}
