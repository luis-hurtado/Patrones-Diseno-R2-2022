using System;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos nuestras elementos
            Figura cuadrado1 = new Figura();
            Figura cuadrado2 = new Figura();

            Figura circulo1 = new Figura();
            Figura circulo2 = new Figura();

            // creamos nuestros grupos
            Grupo grupo1 = new Grupo();
            grupo1.Agregar(cuadrado1);
            grupo1.Agregar(cuadrado2);

            Grupo grupo2 = new Grupo();
            grupo2.Agregar(circulo1);
            grupo2.Agregar(circulo2);

            // llamamos a las operaciones de grupo
            //grupo1.Dibujar();
            //grupo2.Dibujar();

            // Crear nuestro grupo principal
            Grupo grupoPrincipal = new Grupo();
            grupoPrincipal.Agregar(grupo1);
            grupoPrincipal.Agregar(grupo2);

            grupoPrincipal.Dibujar();
            grupoPrincipal.Mover();

            Console.ReadLine();
        }
    }
}
