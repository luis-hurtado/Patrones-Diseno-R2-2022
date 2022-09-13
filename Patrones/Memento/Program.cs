using System;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();

            editor.Content = "primera edicion";
            editor.Content += ", segunda edicion";
            editor.Content += ", tercera edicion";
            //editor.Undo();
            // El resultado deberia ser volver a la segunda Edicion
            Console.WriteLine(editor.Content);
            

            Console.ReadLine();
        }
    }
}
