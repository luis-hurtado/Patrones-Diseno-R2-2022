using System;

namespace CadenaDeResponsabilidades
{
    internal class Encriptador : Manejador
    {
        public Encriptador(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("ENCRIPTACION");
            Console.WriteLine($"Se encripto el mensaje: /n {request.Mensaje}");
            return true;
        }
    }
}
