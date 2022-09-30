using Command.UIFramework;

namespace Command.Cliente
{

    // Concrete command 1
    internal class ComandoAgregarCliente : IComando
    {
        private ServicioAlCliente customerService;

        public ComandoAgregarCliente(ServicioAlCliente customerService)
        {
            this.customerService = customerService;
        }

        public void Ejecutar()
        {
            customerService.AgregarCliente();
        }
    }
}
