namespace Visitor
{
    internal interface IOperacion
    {
        void Ejecutar(NodoAncla ancla);
        void Ejecutar(NodoCabecera cabecera);
        void Ejecutar(NodoImagen imagen);
    }
}
