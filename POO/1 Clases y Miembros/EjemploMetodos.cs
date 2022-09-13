using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases_y_Miembros
{
    internal class EjemploMetodos
    {
        public string Property1 { get; set; }

        // Metodos que no retornan valor -- Procedimientos
        public void Procedimiento() {
            /*...*/
            Console.WriteLine("Ejecutando logica dentro de un procedimiento");
        }

        // Metodos que retornan valor -- Funciones
        public string Funcion()
        {
            /*...*/
            return "retornando algun valor string desde la funcion";
        }
        // Metodos con parametros de entrada
        public string MetodoConParametros(int param1, string param2, double param3)
        {
            /*...*/
            var valorString = $"Producto:{param2} Precio:{param3} x Cantidad:{param1} = {(param1 * param3).ToString()}  ";
            return valorString;
        }
    }
}
