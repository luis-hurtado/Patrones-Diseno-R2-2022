using Facade.ServicioNotificaciones;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Cliente1
    {
        public static void EnviarMensaje()
        {
            Fachada.ServicioNotificaciones.EnviarMensaje("Enviando el Mensaje desde el cliente 1.", "Daniel");
            Logger log = new Logger();
            log.CrearLog("ESTE ES UN EJEMPLO", Logger.PrioridadLog.Advertencia);

        }
    }
}
