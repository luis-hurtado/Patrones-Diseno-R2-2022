using System.Collections.Generic;

namespace Iterator.Navegador
{
    internal class BrowserHistoryArreglos:IAgregado
    {        
        // Ultimos 10 sitios visitados
        private readonly string[] urls = new string[10];
        int posActual;
        
        
        public string[] Urls { get => urls; }

        public void Push(string url)
        {
            urls[posActual++] = url;
        }

        public string Pop()
        {            
            return urls[--posActual];
        }

        public IIterador CrearIterador()
        {
            return new IteradorArreglos(this);
        }
    }
}
