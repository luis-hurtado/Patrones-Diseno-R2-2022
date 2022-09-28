namespace Template.Banca
{
    internal class Demo
    {
        internal static void Ejecutar()
        {
            // Transferencias de Dinero
            Tarea transferencia = new TareaTransferencias();
            transferencia.Ejecutar();

            // Generar un reporte
            Tarea reporte = new TareaReportes();
            reporte.Ejecutar();

            Tarea cobro = new TareaCobros();
            cobro.Ejecutar();

            EnviarCorreo correo = new EnviarCorreo();
            correo.Ejecutar();
        }
    }
}
