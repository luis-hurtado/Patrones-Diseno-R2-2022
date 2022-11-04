using Facade.Ejercicio.Fachada;

using System;

namespace Facade.Ejercicio
{

    public static class Cajero
    {
        public static void Test()
        {
            CuentaBancaria cuentaUsuario = new CuentaBancaria(92345678, 9234);
            Console.WriteLine(cuentaUsuario);
            cuentaUsuario.DepositarDinero(1000);

            cuentaUsuario = new CuentaBancaria(12345678, 9234);
            Console.WriteLine(cuentaUsuario);
            cuentaUsuario.DepositarDinero(1000);


            cuentaUsuario = new CuentaBancaria(12345678, 1234);
            Console.WriteLine(cuentaUsuario);
            cuentaUsuario.RetirarDinero(50.00);
            cuentaUsuario.RetirarDinero(990.00);
            cuentaUsuario.DepositarDinero(1000);
            cuentaUsuario.RetirarDinero(990.00);
        }
    }
}