using System;

namespace Objetos.Herencia
{
    public class Demo
    {
        public static void Ejecutar()
        {
            var textBox = new MiTextBox();
            // Heredar Funcionalidad
            textBox.Enable();

            ////Extender funcionalidad
            textBox.Disable();

            //// Sobre escribir funcionalidad
            Console.WriteLine( textBox.ToString());
        }
    }
}
