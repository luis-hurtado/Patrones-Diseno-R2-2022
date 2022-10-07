using System;

namespace Observer.Excel.PullStyle
{
    internal class Logger : IObservador
    {
        public void Actualizar()
        {
            Console.WriteLine("Alerta de log - Se actualizó el Data Source");
        }
    }
}
