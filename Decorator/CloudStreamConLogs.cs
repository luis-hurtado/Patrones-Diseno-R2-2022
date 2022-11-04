using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CloudStreamConLogs : IStream
    {
        IStream componente;

        public CloudStreamConLogs(IStream componente)
        {
            this.componente = componente;
        }

        public void Escribir(string data)
        {
            Console.WriteLine("Realizando log antes....");
            componente.Escribir(data);
            Console.WriteLine("Realizando log Despues....");
        }
    }
}
