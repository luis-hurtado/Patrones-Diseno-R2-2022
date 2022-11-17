namespace Proxy
{
    internal class EBookProxy : IEBook
    {
        private readonly string nombreArchivo;
        private EBook eBook;

        public string NombreArchivo => nombreArchivo;

        public EBookProxy(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
        }

        public void Mostrar()
        {
            if(eBook == null)
            {
                eBook = new EBook(nombreArchivo);
            }

            eBook.Mostrar();
        }

    }
}
