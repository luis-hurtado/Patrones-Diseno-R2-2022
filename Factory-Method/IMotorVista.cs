using System.Collections.Generic;

namespace Factory_Method
{
    internal interface IMotorVista
    {
        string Renderizar(string vista, IDictionary<string, object> contexto);
    }
}