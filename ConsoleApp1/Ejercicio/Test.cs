using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototype.Ejercicio
{
    internal static class Test
    {
        public static void Ejecutar()
        {
            //Creamos una tienda
            Tienda tiendaAmiga = new Tienda();
            //Creamos una lista de dispositivos en venta
            List<Dispositivo> dispositivosVendidos = new List<Dispositivo>();

            //Llenamos la lista de productos para la tienda
            tiendaAmiga["iPhone"] = new Dispositivo
            {
                Guid = Guid.Empty,
                Marca = "iPhone",
                Modelo = "X13",
                Precio = 1000
            };
            tiendaAmiga["iPad"] = new Dispositivo
            {
                Guid = Guid.Empty,
                Marca = "iPad",
                Modelo = "A2342",
                Precio = 1200
            };

            //Simulamos el proceso de e-commerce
            Dispositivo iPhoneParaDaniel = tiendaAmiga["iPhone"].Clonar() as Dispositivo;
            iPhoneParaDaniel.Guid = Guid.NewGuid();
            iPhoneParaDaniel.Duenio = "Daniel";
            dispositivosVendidos.Add(iPhoneParaDaniel);

            Dispositivo iPhoneParaWilmer = tiendaAmiga["iPhone"].Clonar() as Dispositivo;
            iPhoneParaWilmer.Guid = Guid.NewGuid();
            iPhoneParaWilmer.Duenio = "Wilmer";
            dispositivosVendidos.Add(iPhoneParaWilmer);

            Dispositivo iPadParaArnaldo = tiendaAmiga["iPad"].Clonar() as Dispositivo;
            iPadParaArnaldo.Guid = Guid.NewGuid();
            iPadParaArnaldo.Duenio = "Arnaldo";
            dispositivosVendidos.Add(iPadParaArnaldo);

            //Imprimimos el cierre de caja al final del dia
            IEnumerable<Dispositivo> iPhones = dispositivosVendidos.Where(d => d.Marca == "iPhone");
            IEnumerable<Dispositivo> iPads = dispositivosVendidos.Where(d => d.Marca == "iPad");
            Console.WriteLine("\n\n\nMostramos todos los dispositivos vendidos");
            Console.WriteLine("--------- ----- --- ------- --------");
            foreach (Dispositivo dispositivo in dispositivosVendidos)
            {
                Console.Write(dispositivo);
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("\n\n\nMostramos todos los iPhones vendidos");
            Console.WriteLine("--------- ----- --- ------- --------");

            foreach (Dispositivo dispositivo in iPhones)
            {
                Console.Write(dispositivo);
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("\n\n\nMostramos todos los iPads vendidos");
            Console.WriteLine("--------- ----- --- ------- --------");

            foreach (Dispositivo dispositivo in iPads)
            {
                Console.Write(dispositivo);
            }
        }
    }
}
