using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaDeResponsabilidades
{
    internal class HttpRequest
    {
        public string Usuario { get; internal set; }
        public string Password { get; internal set; }
        public string Mensaje { get; internal set; }
    }
}
