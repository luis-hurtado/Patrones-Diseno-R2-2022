using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Excel.PullStyle
{
    internal class HojaTrabajo : IObservador
    {
        DatosOrigen origen;
        public HojaTrabajo(DatosOrigen origen)
        {
            this.origen = origen;
        }

        public void Actualizar()
        {
            Console.WriteLine($"Se actualizó la Hoja de Tranbajo con el valor {origen.GetValor()}");
        }
    }
}
