using System;

namespace CadenaDeResponsabilidades
{
    internal class Autenticador : Manejador
    {
        public Autenticador(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("AUTENTICACION");
            bool estaAutenticado = request.Usuario == "Admin" && request.Password == "1234";
            Console.WriteLine(estaAutenticado?"El usuario ha sido autenticado satisfactoriamente": "Usuario no valido");
            return estaAutenticado;
        }
    }
}
