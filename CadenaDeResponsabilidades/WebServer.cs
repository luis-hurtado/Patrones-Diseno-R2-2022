namespace CadenaDeResponsabilidades
{
    internal class WebServer
    {
        private readonly Manejador manejador;

        public WebServer(Manejador manejador)
        {
            this.manejador = manejador;
        }

        public void ManejarRequest(HttpRequest request)
        {
            manejador.Manejar(request);
        }
    }
}
