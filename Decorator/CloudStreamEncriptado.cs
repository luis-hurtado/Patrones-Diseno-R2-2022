using System;

namespace Decorator
{
    internal class CloudStreamEncriptado : IStream
    {
        IStream componente;

        public CloudStreamEncriptado(IStream componente)
        {
            this.componente = componente;
        }

        public  void Escribir(string data)
        {
            var dataEncriptada = Encriptar(data);
            componente.Escribir(dataEncriptada);
        }

        private string Encriptar(string data)
        {
            return "!%@asd@sas$@@@xxx.";
        }
    }
}