using Factory_Method.Cobra;
using Factory_Method.Halcon;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    internal class ControladorProductos : ControladorCobra
    {
        public void ListarProductos()
        {
            // Conectando a la base de datos => DB
            // var productos = DB.ObtenerProductos();
            IDictionary<string, object> contexto = new Dictionary<string, object>();
            // for producto in producttos
            // contexto.put (producto)
            Renderizar("Productos.html", contexto);
        }
    }
}
