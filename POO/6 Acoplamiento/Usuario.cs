using System;

namespace Objetos.Acoplamiento
{
    class Usuario
    {
        private string nombre;
        public string apellido;

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        internal void Saludar()
        {
            Console.WriteLine("Hola " + nombre + apellido);
        }
    }
}
