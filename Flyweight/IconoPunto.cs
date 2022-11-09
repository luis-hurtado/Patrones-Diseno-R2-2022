using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class IconoPunto
    {
        private TipoPunto tipo; // 4 bytes
        private sbyte[] icono; // 20 kbytes * 1000 = 20Mb.

        public IconoPunto(TipoPunto tipo, sbyte[] icono)
        {
            this.Tipo = tipo;
            this.icono = icono;
        }

        internal TipoPunto Tipo { get => tipo; set => tipo = value; }
    }
}
