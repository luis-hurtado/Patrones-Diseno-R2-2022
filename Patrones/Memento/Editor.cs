using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Editor
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public EditorState CreateState()
        {
            return new EditorState(content);
        }

        public void RecoverState(EditorState lastState)
        {
            Content = lastState.Content;
        }

    }
}
