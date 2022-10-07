namespace Mediator.UIFramework
{
    enum TipoVista
    {
        Formulario,
        DialogBox,
        Emergente
    }
    internal abstract class Formulario
    {
        TipoVista tipoFormulario = TipoVista.Formulario;
        string titulo = "Nuevo Formulario";

        public string Titulo { get => titulo; set => titulo = value; }
        internal TipoVista TipoFormulario { get => tipoFormulario; set => tipoFormulario = value; }

        public abstract void AlCambiar(ControlesUI control);

        public override string ToString()
        {
            return $"tipo formulario: {TipoFormulario} con titulo {Titulo}";
        }
    }
}
