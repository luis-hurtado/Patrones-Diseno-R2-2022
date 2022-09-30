using System;

namespace Command.UIFramework
{
    // Invoker
    internal class Boton
    {
        private IComando comando;

        public Boton(IComando comando)
        {
            this.comando = comando;
        }

        public string Text { get; set; }


        public void Click()
        {
            comando.Ejecutar();
        }
    }
}
