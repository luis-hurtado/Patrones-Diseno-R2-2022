using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Cliente
{
    // Receiver
    internal class ServicioAlCliente
    {
        // Action 1
        public void AgregarCliente()
        {
            Console.WriteLine("Agregamos un cliente a la BD ...");
        }

        // Action 2
        public void EliminarCliente()
        {
            Console.WriteLine("Eliminamos un cliente a la BD ...");
        }

        public void ActualizarCliente()
        {
            Console.WriteLine("Actualizando datos de un cliente ...");
        }

    }
}
