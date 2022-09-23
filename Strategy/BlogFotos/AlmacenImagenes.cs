using System;

namespace Strategy.BlogFotos
{
    internal class AlmacenImagenes
    {
        private ICompresor compresor;
        private IFiltro filtro;

        public AlmacenImagenes(ICompresor compresor, IFiltro filtro)
        {
            this.compresor = compresor;
            this.filtro = filtro;
        }

        public void Guardar(string imagenSeleccionada)
        {
            // Paso 1.- Comprimir nuestra imagen
            compresor.Comprimir();

            // Paso 2.- Aplicar un filtro
            filtro.Aplicar();

            // Paso 3.- Guardar la imagen
            Console.WriteLine($"Se guardo la imagen seleccionada ({imagenSeleccionada}) a la base de datos");
        }
    }
}
