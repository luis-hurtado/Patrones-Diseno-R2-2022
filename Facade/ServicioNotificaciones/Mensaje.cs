namespace Facade.ServicioNotificaciones
{
    public class Mensaje
    {

        public Mensaje(string contenido)
        {
            Contenido = contenido;
        }

        public string Contenido { get; set; }
    }
}