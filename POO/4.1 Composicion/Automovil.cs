namespace Objetos.Composicion
{
    public class Automovil
    {
        private Llanta llantas;
        public Automovil(Llanta miLlanta)
        {
            llantas = miLlanta;
        }
        public Automovil()
        {
            llantas = new Llanta();
        }

        public void InstalarLlanta()
        {
            llantas.AgregarLlanta();
        }

        public int RevisarLlantas()
        {
            return llantas.RevisarLlantas();
        }
    }
}
