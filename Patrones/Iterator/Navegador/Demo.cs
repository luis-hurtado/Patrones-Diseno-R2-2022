using System;

namespace Iterator.Navegador
{
    internal static class Demo
    {
        public static void Ejecutar()
        {
            var historial = new BrowserHistoryListas();
            historial.Push("http://www.youtube.com/");
            historial.Push("http://www.google.com/PlayStore/");
            historial.Push("https://www.spotify.com/");


            var historial2 = new BrowserHistoryArreglos();
            historial2.Push("http://www.google.com/");
            historial2.Push("http://www.wikipedia.com/");
            historial2.Push("https://www.google.com.bo/maps/");


            // Iteramos nuestro historial para mostrarlo en pantalla
            MostrarHistorial(historial);
            MostrarHistorial(historial2);
        }

        private static void MostrarHistorial(IAgregado historial)
        {
            IIterador coleccion = historial.CrearIterador();
            while (coleccion.TieneSiguiente())
            {
                var url = coleccion.Actual();
                Console.WriteLine(url);
                coleccion.Siguiente();
            }
        }
    }
}
