using System.Collections.Generic;

namespace Visitor
{
    internal class DocumentoHtml
    {
        readonly List<INodoHtml> nodos = new List<INodoHtml>();

        public void AgregarNodos(INodoHtml nodo)
        {
            nodos.Add(nodo);
        }

        public void Ejecutar(IOperacion operacion)
        {
            foreach (var nodo in nodos)
            {
                nodo.Ejecutar(operacion);
            }
        }
    }
}
