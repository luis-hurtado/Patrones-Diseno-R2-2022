using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class HerramientaSeleccion : IHerramienta
    {
        public void MouseDown()
        {
            Console.WriteLine("Se muestra el icono de seleccion");
        }

        public void MouseUp()
        {
            Console.WriteLine("Se dibuja un rectangulo segmentado....");
        }
    }
}
