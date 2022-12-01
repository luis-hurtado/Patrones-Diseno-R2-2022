using System;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigManager manejador = ConfigManager.GetInstance();
            manejador.Set("Nombre_Aplicacion", "MiAplicacion");
            manejador.Set("Version", 1);
            Console.WriteLine($"El valor de setting Nombre_Aplicacion es: {manejador.Get("Nombre_Aplicacion")}");

            ConfigManager otroManejador = ConfigManager.GetInstance();
            Console.WriteLine($"El valor de setting Nombre_Aplicacion es: {otroManejador.Get("Nombre_Aplicacion")}");

            if (manejador == otroManejador)
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("Son diferentes");

            Console.ReadLine();
        }
    }
}
