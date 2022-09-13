using System;

namespace Objetos.Composicion
{
    public class Demo
    {

        public static void Ejecutar()
        {
            Llanta llanta = new Llanta();
            Automovil automovil = new Automovil(llanta);
            automovil.InstalarLlanta();
            Console.WriteLine("Mi automovil tiene " + automovil.RevisarLlantas() + " llantas");
            automovil = null;
            Console.WriteLine("Mi automovil tiene " + automovil.RevisarLlantas() + " llantas");
        }

    }
}
