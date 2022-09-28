using System;

namespace Template.Banca
{
    internal class TareaReportes : Tarea
    {
        protected override void EjecutarTarea()
        {
            // Realizamos todos los procesos de generacion de reportes
            // muchas operaciones, llamadas a la BD
            // llamadas a Cristal Reports, etc.
            Console.WriteLine("Se realizó la generacion del reporte ...");
        }
    }
}
