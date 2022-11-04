using Facade.Ejercicio.ServiciosBanco;

using System;

namespace Facade.Ejercicio.Fachada
{
    public class CuentaBancaria
    {
        private readonly int numeroCuenta;
        private readonly int pinSeguridad;

        ValidadorNumeroCuenta validadorCuenta;
        ValidadorPin validadorPin;
        ValidadorFondos validadorFondos;
        readonly BienvenidaAlBanco bienvenida;

        public CuentaBancaria(int newAcctNum, int newSecCode)
        {
            numeroCuenta = newAcctNum;
            pinSeguridad = newSecCode;

            bienvenida = new BienvenidaAlBanco();
            validadorCuenta = new ValidadorNumeroCuenta();
            validadorPin = new ValidadorPin();
            validadorFondos = new ValidadorFondos();

        }

        public int GetAccountNumber() { return numeroCuenta; }

        public int GetSecurityCode() { return pinSeguridad; }

        public void RetirarDinero(double cashToGet)
        {

            if (validadorCuenta.CuentaActiva(GetAccountNumber()) &&
                    validadorPin.PinEsValido(GetSecurityCode()) &&
                    validadorFondos.TieneSuficienteSaldo(cashToGet))
            {
                Console.WriteLine("RetirarDinero: Transaccion Completada\n");
            }
            else
            {
                Console.WriteLine("RetirarDinero: Transaccion Fallo\n");
            }
        }

        public void DepositarDinero(double cashToDeposit)
        {
            if (validadorCuenta.CuentaActiva(GetAccountNumber()) &&
                    validadorPin.PinEsValido(GetSecurityCode()))
            {
                validadorFondos.RealizarDeposito(cashToDeposit);
                Console.WriteLine("DepositarDinero: Transaccion Completada\n");
            }
            else
            {
                Console.WriteLine("DepositarDinero: Transaccion Fallo\n");
            }
        }

        public override string ToString()
        {
            return $"Cuenta: {numeroCuenta}, Pin: {pinSeguridad}";
        }
    }
}