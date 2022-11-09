using System;
using System.Collections.Generic;

namespace Flyweight
{
    internal class FabricaIconosPunto
    {
        private IDictionary<TipoPunto, IconoPunto> iconos = new Dictionary<TipoPunto, IconoPunto>();

        public IconoPunto IconoPorTipo(TipoPunto tipo)
        {
            //si no existe el icono por tipo, tengo que recuperarlo de la base de datos
            if (!iconos.ContainsKey(tipo))
            {
                var iconoPunto = new IconoPunto(tipo, ObtenerIcono(tipo));
                iconos[tipo] = iconoPunto;
            }

            // Si existe devuelvo el existente en memoria de una lista
            return iconos[tipo];
        }

        private sbyte[] ObtenerIcono(TipoPunto tipo)
        {
            Console.WriteLine("Recuperando el icono para el tipo: " + tipo);
            return null;
        }
    }
}
