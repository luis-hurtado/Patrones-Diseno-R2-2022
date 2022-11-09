using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Ejercicio
{
    internal class FabricaFormatoCelda
    {
        private IDictionary<int, FormatoCelda> formatos = new Dictionary<int, FormatoCelda>();

        public FormatoCelda RecuperarFormato(string fontFamily, int tamano, bool esNegrilla)
        {
            int llave = new { fontFamily, tamano, esNegrilla }.GetHashCode();

            //si no existe el icono por tipo, tengo que recuperarlo de la base de datos
            if (!formatos.ContainsKey(llave))
            {
                formatos[llave] = new FormatoCelda(fontFamily, tamano, esNegrilla);
            }

            // Si existe devuelvo el existente en memoria de una lista
            return formatos[llave];
        }
    }
}
