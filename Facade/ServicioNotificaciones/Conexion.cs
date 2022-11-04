using System;

namespace Facade.ServicioNotificaciones
{
    internal class Conexion
    {
        private string direccionIP;

        public Conexion(string direccionIP)
        {
            this.direccionIP = direccionIP;
            System.Console.WriteLine("Se conecto al Servidor: " + direccionIP);
        }

        internal void Desconectar()
        {
            Console.WriteLine("Se desconecto del Servidor: " + direccionIP);
        }
    }
}