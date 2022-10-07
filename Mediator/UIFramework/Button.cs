namespace Mediator.UIFramework
{
    internal class Button : ControlesUI
    {
        private bool habilitado;

        public Button(Formulario owner) : base(owner)
        {
        }

        public bool Habilitado {
            get => habilitado;
            set
            {
                habilitado = value;
                padre.AlCambiar(this);
            } 
        }
    }
}
