using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Navegador
{
    internal class IteradorListas : IIterador
    {
        private BrowserHistoryListas historia;
        private int posItemActual;

        public IteradorListas(BrowserHistoryListas historia)
        {
            this.historia = historia;
        }

        public string Actual()
        {
            return historia.Urls[posItemActual];
        }

        public void Siguiente()
        {
            posItemActual++;
        }

        public bool TieneSiguiente()
        {
            return posItemActual < historia.Urls.Count;
        }
    }
}
