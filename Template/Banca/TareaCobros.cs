using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Banca
{
    internal class TareaCobros : Tarea
    {

        protected override void EjecutarTarea()
        {
            Console.WriteLine("Realizó la tarea de cobros ..");
        }
    }
}
