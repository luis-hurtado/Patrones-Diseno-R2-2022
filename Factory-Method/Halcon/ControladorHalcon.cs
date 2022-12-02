using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method.Halcon
{
    internal class ControladorHalcon : Controlador
    {
        protected override IMotorVista FabricarMotorVista()
        {
            return new MotorVistaHalcon();
        }
    }
}
