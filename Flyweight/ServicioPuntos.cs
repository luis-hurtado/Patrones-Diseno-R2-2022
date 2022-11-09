using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Flyweight
{
    internal class ServicioPuntos
    {
        private FabricaIconosPunto fabrica;

        public ServicioPuntos(FabricaIconosPunto fabrica)
        {
            this.fabrica = fabrica;
        }

        public List<Punto> ObtenerPuntos()
        {
            // Conectar a la base de datos
            // Recuperar la informacion
            // Lee los registro en la lista
            List<Punto> puntos = new List<Punto>()
            {
                new Punto(1,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(2,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(3,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(4,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(5,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(6,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                new Punto(7,15,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                //new Punto(2,25,fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                //new Punto(3,35,fabrica.IconoPorTipo(TipoPunto.GASOLINERA)),
                //new Punto(2,45,fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                //new Punto(16,55,fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
                //new Punto(1,65,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                //new Punto(2,75,fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                //new Punto(3,85,fabrica.IconoPorTipo(TipoPunto.GASOLINERA)),
                //new Punto(23,95,fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                //new Punto(1,95,fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
                //new Punto(14,85,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                //new Punto(32,75,fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                //new Punto(3,65,fabrica.IconoPorTipo(TipoPunto.GASOLINERA)),
                //new Punto(27,55,fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                //new Punto(1,45,fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
                //new Punto(1,35,fabrica.IconoPorTipo(TipoPunto.CAFE)),
                //new Punto(23,15,fabrica.IconoPorTipo(TipoPunto.ESCUELA)),
                //new Punto(3,25,fabrica.IconoPorTipo(TipoPunto.GASOLINERA)),
                //new Punto(22,145,fabrica.IconoPorTipo(TipoPunto.HOSPITAL)),
                //new Punto(15,155,fabrica.IconoPorTipo(TipoPunto.RESTAURANTE)),
            };
            // retorna la lista
            return puntos;
        }
    }
}
