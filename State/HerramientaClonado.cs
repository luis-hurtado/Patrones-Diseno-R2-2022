using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class HerramientaClonado : IHerramienta
    {
        public void MouseDown()
        {
            // aqui puedo tener toda la logica necesaria
            Console.WriteLine("CambiarIcono");
            SeleccionarObjeto();
            DibujaLineas();
        }

        private static void DibujaLineas()
        {
            Console.WriteLine("dibujar lineas segmentadas al rededor del objeto");
        }

        private static void SeleccionarObjeto()
        {
            Console.WriteLine("seleccionar el objeto sobre el cual esta el mouse");
        }

        public void MouseUp()
        {
            Console.WriteLine("presentamos una copia del objeto seleccionado");
            Console.WriteLine("muestre un mensaje de finalizado");
        }
    }
}
