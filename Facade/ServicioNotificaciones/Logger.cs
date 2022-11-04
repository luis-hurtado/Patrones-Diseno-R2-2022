using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ServicioNotificaciones
{

    internal class Logger
    {
        public enum PrioridadLog
        {
            Error,
            Advertencia,
            Mensaje
        }
        public void CrearLog(string log, PrioridadLog prioridad)
        {
            Console.WriteLine($"Se realizo el log : {log} - {prioridad.ToString()}");
        }
    }
}
