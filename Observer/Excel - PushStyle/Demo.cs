namespace Observer.Excel.PushStyle
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            // Sujeto Observable
            DatosOrigen dataSource = new DatosOrigen();

            // Observadores
            var HojaTotales = new HojaTrabajo();
            var HojaDetalles = new HojaTrabajo();
            var pieChart = new Grafico();

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

            dataSource.SetValor(7);
            // Actualizar hoja de trabajo
            // Actualizar Grafico

        }
    }
}
