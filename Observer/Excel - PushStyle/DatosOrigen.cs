namespace Observer.Excel.PushStyle
{
    internal class DatosOrigen : SujetoObservable
    {
        int valor = 0;

        public int GetValor()
        {
            return valor;
        }

        public void SetValor(int valor)
        {
            this.valor = valor;
            ActualizarObservadores(valor);
        }

    }
}
