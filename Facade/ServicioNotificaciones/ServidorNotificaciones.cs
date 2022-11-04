using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ServicioNotificaciones
{
    internal class ServidorNotificaciones
    {
        //Paso1.- Conectarnos al Servidor
        public Conexion Conectar(string direccionIP)
        {
            return new Conexion(direccionIP);
        }

        //Paso2: Autenticarse
        public AutenticacionPorToken Autenticarse(string idAplicacion, string llave)
        {
            return new AutenticacionPorToken(idAplicacion, llave);
        }

        //Paso3: Enviar el mensaje
        public void EnviarMensaje (AutenticacionPorToken token, Mensaje mensaje, string destinatario)
        {
            Console.WriteLine("Enviando el mensaje: " + mensaje.Contenido);
            Console.WriteLine("a: " + destinatario);
            Console.WriteLine("usando el token valido: " + token.token);
        }

        //Paso 4: log de los eventos
        public Logger ObtenerLogger()
        {
            return new Logger();
        }

    }
}
