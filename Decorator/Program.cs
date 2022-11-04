using System;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DATOS NORMALES ->");
            IStream stream = new CloudStream();
            stream.Escribir("Datos Normales.");

            Console.WriteLine("DATOS COMPRIMIDOS ->");
            IStream streamComprimido = new CloudStreamComprimido(stream);
            streamComprimido.Escribir("Datos Multimedia.");

            Console.WriteLine("DATOS ENCRIPTADOS ->");
            IStream streamEncriptado = new CloudStreamEncriptado(stream);
            streamEncriptado.Escribir("Datos Confidenciales.");

            Console.WriteLine("DATOS CON LOG ->");
            IStream streamConLog = new CloudStreamConLogs(stream);
            streamConLog.Escribir("Datos Normales pero con log.");

            Console.WriteLine("DATOS ENCRIPTADOS y COMPRIMIDO ->");
            IStream streamEncriptadoYComprimido = new CloudStreamEncriptado(new CloudStreamComprimido(stream));
            streamEncriptadoYComprimido.Escribir("Datos Confidenciales.");

            Console.WriteLine("DATOS CON LOG ENCRIPTADOS Y COMPRIMIDOS ->");
            IStream streamConLog2 = new CloudStreamConLogs(streamEncriptadoYComprimido);
            streamConLog2.Escribir("Datos Normales pero con log.");

            Console.WriteLine("DATOS CON LOG Y COMPRIMIDOS ->");
            IStream streamConLog3 = new CloudStreamConLogs(streamComprimido);
            streamConLog3.Escribir("Aquiiii ...Datos Normales pero con log.");


            Console.ReadLine();
        }
    }
}
