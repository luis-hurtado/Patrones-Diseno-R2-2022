using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Navegador
{
    internal interface IIterador
    {
        bool TieneSiguiente();
        string Actual();
        void Siguiente();
    }
}
