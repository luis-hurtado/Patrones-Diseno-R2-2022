namespace Bridge
{
    internal class ControlRemotoAvanzado : ControlRemoto
    {
        public ControlRemotoAvanzado(IDispositivo dispositivo) : base(dispositivo)
        {
        }

        public void EstablecerCanal(int canal)
        {
            dispositivo.EstablecerCanal(canal);
        }
    }
}
