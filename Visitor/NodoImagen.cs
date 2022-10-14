namespace Visitor
{
    internal class NodoImagen : INodoHtml
    {
        public void Ejecutar(IOperacion operacion)
        {
            operacion.Ejecutar(this);
        }
    }
}
