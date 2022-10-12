namespace CadenaDeResponsabilidades
{
    internal abstract class Manejador
    {
        protected Manejador siguiente;

        protected Manejador(Manejador siguiente)
        {
            this.siguiente = siguiente;
        }

        public void Manejar(HttpRequest request)
        {
            if (!ImplementarManejo(request))
                return;

            if(siguiente != null)
                siguiente.Manejar(request);

        }

        public abstract bool ImplementarManejo(HttpRequest request);
    }
}
