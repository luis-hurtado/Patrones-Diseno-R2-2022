using System;

namespace Template.Banca
{
    internal class PistaAuditoria
    {
        public void GenerarLog()
        {
            var fecha = DateTime.Now;
            Console.WriteLine($"{fecha.ToShortDateString()} {fecha.ToShortTimeString()}  - se registro la tarea");
        }
    }
}
