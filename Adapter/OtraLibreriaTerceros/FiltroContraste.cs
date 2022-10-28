using System;

namespace Adapter.OtraLibreriaTerceros
{
    internal class FiltroContraste : IFiltroTerceros
    {
        string filtro;

        public void InicializarOtro(Imagen imagen)
        {
            filtro = $"Aplicando el filtro de terceros (Contraste) a la imagen: {imagen.Nombre}";
        }

        public void UsarOtroFiltro()
        {
            Console.WriteLine(filtro);
            Console.WriteLine("Fin proceso filtro por terceros");
        }
    }
}
