using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Excel
{
    internal class Grafico : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Se actualizó el gráfico");
        }
    }
}
