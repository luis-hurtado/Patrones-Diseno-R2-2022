using System;

namespace Strategy.BlogFotos
{
    internal class CompresorJpg : ICompresor
    {
        public void Comprimir()
        {
            Console.WriteLine("Ejecutamos el algoritmo para la compresion en JPG");
        }
    }
}
