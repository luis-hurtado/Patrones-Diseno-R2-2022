using System.Collections.Generic;

namespace Factory_Method.Halcon
{
    internal class MotorVistaHalcon : IMotorVista
    {
        public string Renderizar(string vista, IDictionary<string, object> contexto)
        {
            return "Vista es renderizada por el framework Halcon";
        }
    }
}
