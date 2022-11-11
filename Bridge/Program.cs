using System;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*****************************************
             * Controles Remotos
             * - Basico
             *      - TV Sony
             *      - TV Samsung
             * - Avanzado
             *      - TV Sony
             *      - TV Samsung
            *****************************************/
            IDispositivo tvSony = new TVSony();
            ControlRemoto controlRemoto = new ControlRemoto(tvSony);
            controlRemoto.Encender();
            controlRemoto.Apagar();

            Console.WriteLine();

            IDispositivo tvSamsung = new TVSamsung();
            ControlRemotoAvanzado controlRemotoAvanzado = new ControlRemotoAvanzado(tvSamsung);
            controlRemotoAvanzado.Encender();
            controlRemotoAvanzado.EstablecerCanal(700);
            controlRemotoAvanzado.Apagar();

            Console.ReadLine();
        }
    }
}
