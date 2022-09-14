using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class History
    {
        List<EditorState> status  = new List<EditorState>();

        public void Push(EditorState state)
        {
            status.Add(state);
        }

        public EditorState Pop()
        {
            var index = status.Count - 1;
            var lastState = status[index];
            status.Remove(lastState);
            return lastState;
        }

    }
}
/*
 add(x) -> x
add (y) -> xy
add(z) -> xyz
ultimo estado = remove(z) -> xy
 */