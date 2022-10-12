using System;

namespace CadenaDeResponsabilidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Autenticar -> log -> comprimir
            Encriptador encriptador = new Encriptador(null);
            Compressor compressor = new Compressor(encriptador);
            Autenticador autenticador = new Autenticador(compressor);
            //Logger logger = new Logger(autenticador);

            // Declarar nuestro web server
            WebServer servidor = new WebServer(autenticador);

            // Creamos nuestro Request
            HttpRequest request = new HttpRequest
            {
                Usuario = "Admin", //"user", //
                Password = "1234",
                Mensaje = "Hola mundo"
            };

            // Atendemos el Request
            servidor.ManejarRequest(request);

            Console.ReadLine();
        }
    }
}
