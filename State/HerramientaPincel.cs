using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class HerramientaPincel : IHerramienta
    {
        public void MouseDown()
        {
            Console.WriteLine("Se muestra el icono de pincel");
        }

        public void MouseUp()
        {
            Console.WriteLine("Se dibuja un linea de trazo libre coloreada ....");
        }
    }
}
