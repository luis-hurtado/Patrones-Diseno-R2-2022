using System;

namespace Facade.Ejercicio.ServiciosBanco
{
    public class ValidadorNumeroCuenta
    {
        private readonly int numeroDeCuenta = 12345678;

        public int ObtenerNumeroDeCuenta() { return numeroDeCuenta; }

        public bool CuentaActiva(int numeroCuentaAValidar)
        {
            if (numeroCuentaAValidar == ObtenerNumeroDeCuenta())
            {
                return true;
            }
            else
            {
                Console.WriteLine("ValidadorNumeroCuenta: La cuenta esta Inactiva.");
                return false;
            }
        }
    }
}