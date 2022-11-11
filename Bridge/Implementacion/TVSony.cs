using System;

namespace Bridge
{
    internal class TVSony : IDispositivo
    {
        public void Apagar()
        {
            Console.WriteLine("Apagando Dispositivo Sony...");
        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo Dispositivo Sony...");
        }

        public void EstablecerCanal(int canal)
        {
            Console.WriteLine("Cambiando la TV Sony al canal: " + canal);
        }
    }
}
