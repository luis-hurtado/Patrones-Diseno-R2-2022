using System;

namespace Bridge
{
    internal class TVSamsung : IDispositivo
    {
        public void Apagar()
        {
            Console.WriteLine("Apagando Dispositivo Samsung...");
        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo Dispositivo Samsung...");
        }

        public void EstablecerCanal(int canal)
        {
            Console.WriteLine("Cambiando la TV Samsung al canal: " + canal);
        }
    }
}
