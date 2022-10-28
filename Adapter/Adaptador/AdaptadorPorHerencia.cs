using Adapter.LibreriaPropia;
using Adapter.OtraLibreriaTerceros;

namespace Adapter.Adaptador
{
    internal class AdaptadorPorHerencia : FiltroContraste, IFiltro
    {
        public void Aplicar(Imagen imagen)
        {
            InicializarOtro(imagen);
            UsarOtroFiltro();
        }
    }
}
