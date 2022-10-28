using Adapter.LibreriaPropia;

namespace Adapter
{
    internal class VisorImagen
    {
        private Imagen imagen;

        public VisorImagen(Imagen imagen)
        {
            this.imagen = imagen;
        }

        public void btnAplicarFiltroClick(IFiltro filtro)
        {
            filtro.Aplicar(imagen);
        }
    }
}
