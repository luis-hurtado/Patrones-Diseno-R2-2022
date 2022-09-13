using System;

namespace Objetos.Encapsulacion
{
    class Demo
    {
        public static void Ejecutar()
        {
            var cuenta = new Cuenta();
            // Ejemplo cuando el campo es  public
            //cuenta.balance = 10;
            //Console.WriteLine("El estado inicial del balance es: " + cuenta.balance); 
            //cuenta.balance = -1;
            //Console.WriteLine("El estado actual del balance es: " + cuenta.balance);
            //Ejemplo cuando el campo es privado y creamos una propiedad
            //cuenta.Balance = -1;
            //Console.WriteLine("El estado inicial del balance es: " + cuenta.Balance);
            //cuenta.Balance = 15;
            //Console.WriteLine("El estado actual del balance es: " + cuenta.Balance);
            //Ejemplo cuando utilizamos metodos
            //cuenta.Depositar(17);
            //cuenta.Retirar(5);
            //Console.WriteLine("El estado final del balance es: " + cuenta.Balance);
        }
    }
}
