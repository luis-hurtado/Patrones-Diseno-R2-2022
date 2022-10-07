namespace Mediator.UIFramework
{
    internal class TextBox : ControlesUI
    {
        private string texto;

        public TextBox(Formulario owner) : base(owner)
        {
        }

        public string Texto {
            get => texto;
            set {
                texto = value;
                padre.AlCambiar(this);
            }
        }
    }
}
