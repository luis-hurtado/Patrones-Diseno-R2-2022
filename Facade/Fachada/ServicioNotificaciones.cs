using Facade.ServicioNotificaciones;

namespace Facade.Fachada
{
    internal class ServicioNotificaciones
    {
        public static void EnviarMensaje(string mensaje, string destinatario)
        {
            //Comunicarnos con el servidor para enviar mensajes
            var servicio = new ServidorNotificaciones();
            var logger = servicio.ObtenerLogger();
            logger.CrearLog("Antes de conectarse", Logger.PrioridadLog.Mensaje);
            Conexion conexion = servicio.Conectar("10.1.1.125");
            logger.CrearLog("la clave es secreta no la revele", Logger.PrioridadLog.Advertencia);
            AutenticacionPorToken token = servicio.Autenticarse("Aplicacion Ejemplo", "Vmpbugn");
            Mensaje mensajeAEnviar = new Mensaje(mensaje);
            servicio.EnviarMensaje(token, mensajeAEnviar, destinatario);
            conexion.Desconectar();
            logger.CrearLog("Salimos de la clase - Ejemplo de error", Logger.PrioridadLog.Error);
        }
    }
}
