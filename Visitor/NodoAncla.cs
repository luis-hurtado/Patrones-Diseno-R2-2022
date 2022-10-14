using System;

namespace Visitor
{
    internal class NodoAncla : INodoHtml
    {
        public void Ejecutar(IOperacion operacion)
        {
            operacion.Ejecutar(this);
        }
    }
}
