using System;

namespace Objetos.Agregacion
{
    public class Demo
    {
        
        public static void Ejecutar()
        {
            Pedido pedido = new Pedido();
            Cliente cliente = new Cliente(pedido);
            //cliente.SetPedido(pedido);
            cliente.AgregarIemAlPedido();   
            Console.WriteLine("Mi orden tiene " +  cliente.RevisarItems() + " items"); 
            Console.WriteLine("La orden tiene " + pedido.RevisarItems() + " items");
            cliente = null;
            Console.WriteLine("La orden sin cliente tiene " + pedido.RevisarItems() + " items");
        }
        
    }
}
