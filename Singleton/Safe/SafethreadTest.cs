using System;
using System.Threading.Tasks;

namespace Singleton.Safe
{
    internal class SafethreadTest
    {
        public static void Ejecutar()
        {
            int numero_procesos = 8;
            Task[] tasks = new Task[numero_procesos];
            for (int i = 0; i < numero_procesos; i++)
            {
                tasks[i] = Task.Run(() => MemoryCache.Crear());
            }
            Task.WaitAll(tasks);
            // MemoryCache.Crear();
        }
    }
    public class MemoryCache
    {
        private static int i = 0;
        private static MemoryCache _instancia;
        private static object miObjetoDeBloqueo = new object();

        private MemoryCache()
        {
            Console.WriteLine($"Creado {i++}");
        }

        //public static MemoryCache Crear()
        //{
        //    return _instancia ?? (_instancia = new MemoryCache());
        //}

        public static MemoryCache Crear()
        {
            if (_instancia == null)
            {
                lock (miObjetoDeBloqueo)
                {
                    if (_instancia == null)
                    {
                        _instancia = new MemoryCache();
                    }
                }
            }
            return _instancia;
        }

    }
}
