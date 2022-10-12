using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidades
{
    internal class Compressor : Manejador
    {
        public Compressor(Manejador siguiente) : base(siguiente)
        {
        }

        public override bool ImplementarManejo(HttpRequest request)
        {
            Console.WriteLine("COMPRESION");
            Console.WriteLine($"Se comprimio el mensaje: /n {request.Mensaje}");
            return true;
        }
    }
}
