using System;

namespace Visitor
{
    internal class OperacionTextoPlano : IOperacion
    {
        public void Ejecutar(NodoAncla ancla)
        {
            Console.WriteLine("Resaltatando el nodo Ancla ..");
        }

        public void Ejecutar(NodoCabecera cabecera)
        {
            Console.WriteLine("Resaltatando el nodo cabecera ..");
        }

        public void Ejecutar(NodoImagen imagen)
        {
            //Console.WriteLine("Mostrando la imagen");
        }
    }
}
