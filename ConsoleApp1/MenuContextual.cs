namespace Prototype
{
    internal class MenuContextual
    {
        public IComponente Duplicar(IComponente origen)
        {
            return origen.Clonar();
        }
    }
}
