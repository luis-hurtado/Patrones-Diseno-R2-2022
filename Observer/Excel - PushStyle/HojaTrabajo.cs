using System;

namespace Observer.Excel.PushStyle
{
    internal class HojaTrabajo : IObservador
    {
        public void Actualizar(int valor)
        {
            Console.WriteLine($"Se actualizó la Hoja de Tranbajo con el valor {valor}");
        }
    }
}
