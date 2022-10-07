using Mediator.UIFramework;

using System;

namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dialogo = new DialogBoxArticulos
            {
                TipoFormulario = TipoVista.DialogBox,
                Titulo = "Modificacion de Productos"
            };
            Console.WriteLine( dialogo.ToString());

            // deberian estar dentro de un DialoBox
            dialogo.SimularInteraccionUsuario();

            Console.ReadLine();
        }
    }
}
