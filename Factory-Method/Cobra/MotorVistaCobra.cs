using System.Collections.Generic;

namespace Factory_Method.Cobra
{
    internal class MotorVistaCobra : IMotorVista
    {
        public string Renderizar(string vista, IDictionary<string, object> contexto)
        {
            return "Vista es renderizada por el framework Cobra";
        }
    }
}
