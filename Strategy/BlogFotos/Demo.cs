using System;

namespace Strategy.BlogFotos
{
    internal class Demo
    {
        public static void Ejecutar()
        {
            var compresorSeleccionado = new CompresorPng();
            var filtroSeleccionado = new FiltroBlancoYNegro();

            AlmacenImagenes almacen = new AlmacenImagenes(compresorSeleccionado, filtroSeleccionado);
            almacen.Guardar("c://fotos//foto_001.abc");

            Console.WriteLine();
            almacen = new AlmacenImagenes(new CompresorJpg(), filtroSeleccionado);
            almacen.Guardar("c://fotos//foto_002.abc");

            Console.WriteLine();
            almacen = new AlmacenImagenes(compresorSeleccionado, new FiltroAltoContraste());
            almacen.Guardar("c://fotos//foto_003.abc");

            Console.WriteLine();
            almacen = new AlmacenImagenes(new CompresorJpg(), new FiltroAltoContraste());
            almacen.Guardar("c://fotos//foto_004.abc");
        }

    }
}
