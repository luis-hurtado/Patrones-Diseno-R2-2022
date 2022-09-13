using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Interfaces
{
    class CalculadoraImpuesto2021 : ICalculadoraImpuesto, Interface1
    {
        public float CalcularImpuesto()
        {
            return 1400;
        }

        // este cambio no afecta a la clase demo
        public float CalcularSeguro()
        {
            return 2.5F;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
