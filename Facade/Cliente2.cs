using Facade.ServicioNotificaciones;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Cliente2
    {

        public static void EnviarMensaje()
        {
            Fachada.ServicioNotificaciones.EnviarMensaje("Enviando el Mensaje desde el cliente 2.", "Wilmer");
        }
    }
}
