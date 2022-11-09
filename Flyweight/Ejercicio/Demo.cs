namespace Flyweight.Ejercicio
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            
            Hoja hoja = new Hoja(new FabricaFormatoCelda());
            hoja.EstablecerContenido("1", "A", "Hola mundo");
            hoja.EstablecerFuente("1", "A", "Times New Roman");
            hoja.EstablecerContenido("2", "B", "Esto es una Prueba");
            hoja.EstablecerContenido("1", "C", "Jugando con la negrilla");
            hoja.EstablecerNegrita("1", "C", true);
            hoja.EstablecerTamano("1", "C", 24);
            hoja.Mostrar();
        }
    }
}
