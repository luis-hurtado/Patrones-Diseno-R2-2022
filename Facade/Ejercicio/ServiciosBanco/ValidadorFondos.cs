using System;

namespace Facade.Ejercicio.ServiciosBanco
{
    public class ValidadorFondos
    {

        private double dineroEnCuenta = 1000.00;

        public double ObtenerSaldo() { return dineroEnCuenta; }

        public void DebitarMonto(double dineroRetirado) { dineroEnCuenta -= dineroRetirado; }

        public void AcreditarMonto(double dineroDepositado) { dineroEnCuenta += dineroDepositado; }

        public bool TieneSuficienteSaldo(double montoAValidar)
        {

            if (montoAValidar > ObtenerSaldo())
            {
                Console.WriteLine("Error: No cuenta con suficiente dinero");
                Console.WriteLine("Balance Actual: " + ObtenerSaldo());

                return false;
            }
            else
            {
                DebitarMonto(montoAValidar);
                Console.WriteLine("Retiro Completo: Balance actual es " + ObtenerSaldo());

                return true;
            }

        }

        public void RealizarDeposito(double motoADepositar)
        {
            AcreditarMonto(motoADepositar);
            Console.WriteLine("Deposito Completo: Balance actual es " + ObtenerSaldo());
        }

    }
}