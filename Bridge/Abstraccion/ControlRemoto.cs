namespace Bridge
{
    internal class ControlRemoto
    {
        protected IDispositivo dispositivo;

        public ControlRemoto(IDispositivo dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        public void Encender()
        {
            dispositivo.Encender();
            dispositivo.EstablecerCanal(1);
            System.Console.WriteLine("Gracias por usar mi control remoto");
        }

        public void Apagar()
        {
            dispositivo.Apagar();
        }
    }
}
