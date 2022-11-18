using System.Collections;

namespace Prototype.Ejercicio
{
    internal class Tienda
    {
        private readonly Hashtable dispositivos = new Hashtable();

        public IDispositivo this[string nombre]
        {
            get => dispositivos.ContainsKey(nombre)
                           ? dispositivos[nombre] as IDispositivo
                           : null;

            set => dispositivos.Add(nombre, value);
        }
    }
}
