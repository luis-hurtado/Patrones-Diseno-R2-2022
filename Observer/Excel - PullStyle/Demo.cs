namespace Observer.Excel.PullStyle
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            // Sujeto Observable
            DatosOrigen dataSource = new DatosOrigen();

            // Observadores
            var HojaTotales = new HojaTrabajo(dataSource);
            var HojaDetalles = new HojaTrabajo(dataSource);
            var pieChart = new Grafico(dataSource);
            var logger = new Logger();

            // Agregar los observadores a nuestra lista para el DataSource
            dataSource.AgregarObservador(HojaTotales);
            dataSource.AgregarObservador(HojaDetalles);
            dataSource.AgregarObservador(pieChart);

            // Actualizamos el estado del sujeto observable
            dataSource.SetValor(5);
            // Actualizar hoja de trabajo (Totales y Detalles)
            // Actualizar Grafico (Pie Chart)

            // Si necesitamos podemos eliminar a algunos observadores
            dataSource.EliminarrObservador(HojaDetalles);
            dataSource.AgregarObservador(logger);

            dataSource.SetValor(7);
            // Actualizar hoja de trabajo
            // Actualizar Grafico
            dataSource.SetValor(10);

        }
    }
}
