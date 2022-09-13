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

    }
}
