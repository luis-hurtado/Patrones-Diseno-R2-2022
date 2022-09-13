using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Interfaces
{
    public class Demo
    {
        public static void Ejecutar(int anio)
        {
            ICalculadoraImpuesto calculadora = GetCalculadora(anio);
            //CalculadoraImpuesto2021 calculadora = new CalculadoraImpuesto2021();
            var impuesto = calculadora.CalcularImpuesto();
            Console.WriteLine($"El impuesto calculado para el año {anio} es: {impuesto} ");

            Interface1 objeto = new CalculadoraImpuesto2021();
            objeto.Saludar();
        }


        // En una aplicacion de la vida real utilizariamos dependenci injection.
        private static ICalculadoraImpuesto GetCalculadora(int anio)
        {
            if (anio == 2021)
                return new CalculadoraImpuesto2021();
            else
                return new CalculadoraImpuesto2022();
        }
    }
}
