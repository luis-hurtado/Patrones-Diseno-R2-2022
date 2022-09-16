using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class HerramientaBorrador : IHerramienta
    {
        public void MouseDown()
        {
            Console.WriteLine("Mostrar icono de borrador");
        }

        public void MouseUp()
        {
            Console.WriteLine("Eliminar/Borrar el area seleccionada");
        }
    }
}
