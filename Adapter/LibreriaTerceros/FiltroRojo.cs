using System;

namespace Adapter.LibreriaTerceros
{
    internal class FiltroRojo : IFiltroTerceros
    {
        string filtro;

        public void Inicializar()
        {
            filtro = "Aplicando el filtro de terceros (Rojo) a la imagen";
        }

        public void UsarFiltro(Imagen imagen)
        {
            Console.WriteLine(filtro);
            Console.WriteLine(imagen.Nombre);
            Console.WriteLine("Fin proceso filtro por terceros");
        }
    }
}
