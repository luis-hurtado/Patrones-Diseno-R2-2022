namespace Mediator.UIFramework
{
    internal class ListBox : ControlesUI
    {
        private string itemSeleccionado;

        public ListBox(Formulario owner) : base(owner)
        {
        }

        public string ItemSeleccionado
        {
            get { return itemSeleccionado; }

            set {
                itemSeleccionado = value;
                padre.AlCambiar(this);
            }
        }
    }
}
