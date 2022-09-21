using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Navegador
{
    internal class IteradorArreglos : IIterador
    {
        private BrowserHistoryArreglos historia;
        private int posItemActual;

        public IteradorArreglos(BrowserHistoryArreglos historia)
        {
            this.historia = historia;
        }
        public string Actual()
        {
            return historia.Urls[posItemActual];
        }

        public void Siguiente()
        {
            posItemActual ++;
        }

        public bool TieneSiguiente()
        {
            return posItemActual < historia.Urls.Length -1;
        }
    }
}
