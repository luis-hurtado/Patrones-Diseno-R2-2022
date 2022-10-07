using System.Collections.Generic;

namespace Observer.Excel.PushStyle
{
    internal abstract class SujetoObservable
    {
        readonly List<IObservador> observadores = new List<IObservador>();

        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void EliminarrObservador(IObservador observador)
        {
            observadores.Remove(observador);
        }

        public void ActualizarObservadores(int valor)
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar(valor);
            }
        }


    }
}
