using Adapter.LibreriaPropia;
using Adapter.LibreriaTerceros;

namespace Adapter.Adaptador
{
    internal class AdaptadorFiltroTerceros : IFiltro
    {
        private readonly IFiltroTerceros filtroTerceros;

        public AdaptadorFiltroTerceros(IFiltroTerceros filtroTerceros)
        {
            this.filtroTerceros = filtroTerceros;
        }

        public void Aplicar(Imagen imagen)
        {
            filtroTerceros.Inicializar();
            filtroTerceros.UsarFiltro(imagen);
        }
    }
}
