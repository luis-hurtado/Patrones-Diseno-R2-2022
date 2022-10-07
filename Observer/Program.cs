using Observer.Excel;

using System;
using pushStyle = Observer.Excel.PushStyle;
using pullStyle = Observer.Excel.PullStyle;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demo Basico
            //Console.WriteLine("Demo Basico");
            //Demo.Ejecutar();

            // Demo Push Style
            //Console.WriteLine();
            //Console.WriteLine("Demo Push Style");
            //pushStyle.Demo.Ejecutar();

            // Demo Pull Style
            Console.WriteLine();
            Console.WriteLine("Demo Pull Style");
            pullStyle.Demo.Ejecutar();

            Console.ReadLine();
        }
    }
}
