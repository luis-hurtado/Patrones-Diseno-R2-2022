using System;

namespace Objetos.Polimorfismo
{
    class Perro : Animal
    {
        public Perro() : base()
        {
            Sonido = "Guauuu, guau ....";
        }
        public override void Jugar()
        {
            System.Console.WriteLine("Jugando con mi hueso");            
        }

        public virtual void HacerHuecos()
        {
            Console.WriteLine("hoyo cavado...");
        }

        public void Salta()
        {
            Console.WriteLine("Mi perro salta 10 metros");
        }

        public void Salta (int metros)
        {
            Console.WriteLine($"Mi perro salta {metros} metros");
        }
    }
}
