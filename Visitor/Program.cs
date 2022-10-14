using System;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creamos nuestro documento html
            var documento = new DocumentoHtml();

            // agregar nodos
            documento.AgregarNodos(new NodoCabecera());
            documento.AgregarNodos(new NodoAncla());
            documento.AgregarNodos(new NodoImagen());

            Console.WriteLine("TEXTO RESALTADO");
            // procesamos el documento para resaltarlo
            documento.Ejecutar(new OperacionResaltar());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("TEXTO PLANO");
            // documento.ObtenerTextoSinFormato()
            documento.Ejecutar(new OperacionTextoPlano());

            Console.ReadLine();
        }
    }
}
