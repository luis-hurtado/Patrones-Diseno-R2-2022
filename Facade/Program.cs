using Facade.ServicioNotificaciones;

using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //Cliente1.EnviarMensaje();
            //Cliente2.EnviarMensaje();
            //Cliente3.EnviarMensaje();
            //Fachada.ServicioNotificaciones.EnviarMensaje("Saludos Alumnos no se duerman...", "Alunnos del curso de Patrones");
            //Fachada.ServicioNotificaciones.EnviarMensaje("Se entendio este Patron?", "Alunnos del curso de Patrones");

            Ejercicio.Cajero.Test();

            Console.ReadLine();
        }
    }
}
