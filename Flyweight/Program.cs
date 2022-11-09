using System;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EjecutarClase();
            Ejercicio.Demo.Ejecutar();

            Console.ReadLine();
        }

        private static void EjecutarClase()
        {
            var servicio = new ServicioPuntos(new FabricaIconosPunto());
            var puntos = servicio.ObtenerPuntos();
            // Dibujar los puntos en el mapa
            foreach (Punto punto in puntos)
            {
                punto.Dibujar();
            }
        }
    }
}
