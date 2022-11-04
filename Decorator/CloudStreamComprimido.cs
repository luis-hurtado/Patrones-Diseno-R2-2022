namespace Decorator
{
    internal class CloudStreamComprimido : IStream
    {
        readonly IStream componente;

        public CloudStreamComprimido(IStream componente)
        {
            this.componente = componente;
        }

        public void Escribir(string data)
        {
            var dataComprimida = Comprimir(data);
            componente.Escribir(dataComprimida);
        }

        private string Comprimir(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
