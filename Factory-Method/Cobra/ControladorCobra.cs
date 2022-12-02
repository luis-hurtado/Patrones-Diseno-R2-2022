namespace Factory_Method.Cobra
{
    internal class ControladorCobra : Controlador
    {
        protected override IMotorVista FabricarMotorVista()
        {
            return new MotorVistaCobra();
        }
    }
}
