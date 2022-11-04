using System;

namespace Decorator
{
    internal class CloudStream : IStream
    {
        public void Escribir(string data)
        {
            Console.WriteLine("Almacenando en la nube: " + data);
        }
    }
}
