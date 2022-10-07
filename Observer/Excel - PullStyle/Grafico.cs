using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Excel.PullStyle
{
    internal class Grafico : IObservador
    {
        DatosOrigen origen;

        public Grafico(DatosOrigen origen)
        {
            this.origen = origen;
        }

        public void Actualizar()
        {
            Console.WriteLine($"Se actualizó el Gráfico con el valor {origen.GetValor()}");
        }
    }
}
