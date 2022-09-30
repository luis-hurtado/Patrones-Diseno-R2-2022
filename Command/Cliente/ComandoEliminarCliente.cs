using Command.UIFramework;

namespace Command.Cliente
{
    // Concrete command 2
    internal class ComandoEliminarCliente : IComando
    {
        private ServicioAlCliente customerService;

        public ComandoEliminarCliente(ServicioAlCliente customerService)
        {
            this.customerService = customerService;
        }

        public void Ejecutar()
        {
            customerService.EliminarCliente();
        }
    }
}
