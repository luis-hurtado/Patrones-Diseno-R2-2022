using System;

namespace Visitor
{
    internal class NodoCabecera : INodoHtml
    {
        public void Ejecutar(IOperacion operacion)
        {
            operacion.Ejecutar(this);
        }
    }
}
