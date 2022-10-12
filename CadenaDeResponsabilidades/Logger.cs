using System;

namespace CadenaDeResponsabilidades
{
    internal class Logger : Manejador
    {
        public Logger(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("REGISTRO DE LOGS...");
            Console.WriteLine($"Se ejecuto un request a horas {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()} para el usuario {request.Usuario}");
            return true;
        }
    }
}
