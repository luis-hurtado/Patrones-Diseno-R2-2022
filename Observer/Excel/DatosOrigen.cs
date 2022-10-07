using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Excel
{
    internal class DatosOrigen : SujetoObservable
    {
        int valor = 0;

        public int GetValor()
        {
            return valor;
        }

        public void SetValor(int valor)
        {
            this.valor = valor;
            ActualizarObservadores();
        }

    }
}
