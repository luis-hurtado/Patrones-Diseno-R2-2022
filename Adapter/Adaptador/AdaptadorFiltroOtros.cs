using Adapter.LibreriaPropia;
using Adapter.OtraLibreriaTerceros;

namespace Adapter.Adaptador
{
    internal class AdaptadorFiltroOtros : IFiltro
    {
        private readonly IFiltroTerceros filtroTerceros;

        public AdaptadorFiltroOtros(IFiltroTerceros filtroTerceros)
        {
            this.filtroTerceros = filtroTerceros;
        }

        public void Aplicar(Imagen imagen)
        {
            filtroTerceros.InicializarOtro(imagen);
            filtroTerceros.UsarOtroFiltro();
        }
    }
}
