using Command.Cliente;
using Command.UIFramework;

namespace Command
{
    // Cliente
    internal static class EjemploCliente
    {
        public static void Ejecutar()
        {

            var servicio = new ServicioAlCliente();

            // Definimos los botones
            IComando comandoAgregar = new ComandoAgregarCliente(servicio);
            Boton btnGuardar = new Boton(comandoAgregar);
            btnGuardar.Text = "Guardar cliente";

            IComando comandoEliminar = new ComandoEliminarCliente(servicio);
            Boton btnEliminar = new Boton(comandoEliminar);
            btnEliminar.Text = "Eliminar cliente";

            IComando comandoActualizar = new ComandoActualizarCliente(servicio);
            Boton btnActualizar = new Boton(comandoActualizar);
            btnActualizar.Text = "Actualizar cliente";

            // Hacemos Click()
            btnGuardar.Click(); 
            btnGuardar.Click(); 
            btnActualizar.Click(); 
            btnGuardar.Click(); 
            btnGuardar.Click(); 
            btnEliminar.Click();

        }
    }
}
