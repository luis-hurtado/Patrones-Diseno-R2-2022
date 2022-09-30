using Command.UIFramework;

using System;

namespace Command.Cliente
{
    internal class ComandoActualizarCliente : IComando
    {
        ServicioAlCliente receiver;

        public ComandoActualizarCliente(ServicioAlCliente receiver)
        {
            this.receiver = receiver;
        }

        public void Ejecutar()
        {
            receiver.ActualizarCliente();
        }
    }
}
