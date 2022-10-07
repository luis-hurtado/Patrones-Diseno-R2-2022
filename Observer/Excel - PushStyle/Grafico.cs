using System;

namespace Observer.Excel.PushStyle
{
    internal class Grafico : IObservador
    {
        public void Actualizar(int valor)
        {
            Console.WriteLine($"Se actualizó el gráfico con el valor {valor}");
        }
    }
}
