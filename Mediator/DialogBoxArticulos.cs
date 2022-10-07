using Mediator.UIFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class DialogBoxArticulos : Formulario
    {
        ListBox lbxProductos;
        TextBox txtProductoSeleccionado;
        Button btnGuardar;

        public DialogBoxArticulos()
        {
            this.lbxProductos = new ListBox(this);
            this.txtProductoSeleccionado = new TextBox(this);
            this.btnGuardar = new Button(this);
        }

        public override void AlCambiar(ControlesUI control)
        {
            if (control == lbxProductos)
                AlCambiarArticuloSeleccionado();
            else if (control == txtProductoSeleccionado)
                AlCambiarElNombreDelProducto();
        }

        private void AlCambiarElNombreDelProducto()
        {
            var estaVacio = string.IsNullOrWhiteSpace(txtProductoSeleccionado.Texto);
            btnGuardar.Habilitado = !estaVacio;
        }

        private void AlCambiarArticuloSeleccionado()
        {
            txtProductoSeleccionado.Texto = lbxProductos.ItemSeleccionado;
            btnGuardar.Habilitado = true;
        }

        internal void SimularInteraccionUsuario()
        {
            Console.WriteLine();
            lbxProductos.ItemSeleccionado = "Articulo 1";
            Console.WriteLine($"TextBox: {txtProductoSeleccionado.Texto} ");
            Console.WriteLine($"Boton  : {btnGuardar.Habilitado} ");

            Console.WriteLine();
            txtProductoSeleccionado.Texto = "";
            Console.WriteLine($"TextBox: {txtProductoSeleccionado.Texto} ");
            Console.WriteLine($"Boton  : {btnGuardar.Habilitado} ");

            Console.WriteLine();
            txtProductoSeleccionado.Texto = "Mi nuevo titulo para el producto";
            Console.WriteLine($"TextBox: {txtProductoSeleccionado.Texto} ");
            Console.WriteLine($"Boton  : {btnGuardar.Habilitado} ");

        }
    }
}
