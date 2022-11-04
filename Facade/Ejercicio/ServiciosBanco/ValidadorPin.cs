using System;

namespace Facade.Ejercicio.ServiciosBanco
{
    public class ValidadorPin
    {

        private readonly int codigoSeguridad = 1234;

        public int ObtenerPinValido() { return codigoSeguridad; }

        public bool PinEsValido(int pinAValidar)
        {

            if (pinAValidar == ObtenerPinValido())
            {
                return true;
            }
            else
            {
                Console.WriteLine("ValidadorPin: El pin ingresado no es valido.");
                return false;
            }

        }

    }
}