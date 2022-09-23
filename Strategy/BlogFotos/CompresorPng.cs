using System;

namespace Strategy.BlogFotos
{
    internal class CompresorPng : ICompresor
    {
        public void Comprimir()
        {
            Console.WriteLine("Ejecutamos el algoritmo para la compresion en PNG");
        }
    }
}
