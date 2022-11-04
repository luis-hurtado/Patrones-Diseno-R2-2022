namespace Facade.ServicioNotificaciones
{
    internal class AutenticacionPorToken
    {
        private string idAplicacion;
        private string llave;

        public AutenticacionPorToken(string idAplicacion, string llave)
        {
            this.idAplicacion = idAplicacion;
            this.llave = llave;
            System.Console.WriteLine($"Generando token para la aplicacion {idAplicacion} con la llave {llave}");
        }

        public string token { get { return "AS12DF!#FD-SF+"; } }
    }
}