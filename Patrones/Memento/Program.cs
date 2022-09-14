using System;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            History history = new History();

            editor.Content = "primera edicion";
            history.Push(editor.CreateState());

            editor.Content += ", segunda edicion";
            history.Push(editor.CreateState());

            editor.Content += ", tercera edicion";
            //history.Push(editor.CreateState());
            Console.WriteLine("antes:" + editor.Content);

            //editor.Undo();
            // El resultado deberia ser volver a la segunda Edicion
            editor.RecoverState(history.Pop());
            Console.WriteLine("despues del pop:" + editor.Content);

            editor.RecoverState(history.Pop());
            Console.WriteLine("despues del pop:" + editor.Content);


            Console.ReadLine();
        }
    }
}
