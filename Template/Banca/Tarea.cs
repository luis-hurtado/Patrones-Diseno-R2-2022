using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Banca
{
    internal abstract class Tarea
    {
        private readonly PistaAuditoria logger;

        public Tarea()
        {
            this.logger = new PistaAuditoria();
        }

        internal void Ejecutar()
        {
            // Paso 1: Generar la pista de auditoria
            logger.GenerarLog();

            // Paso 2: Ejecutar la tarea concreta 
            EjecutarTarea();

            // Paso 3: Generar la pista de auditoria
            logger.GenerarLog();

            // Paso 4: Realice un formato de linea
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine();    
        }

        protected abstract void EjecutarTarea();
    }
}
