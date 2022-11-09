using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Ejercicio
{
    internal class Hoja
    {
        private const int MAX_FILAS = 3;
        private const int MAX_COLUMNAS = 3;
        private Celda[,] celdas = new Celda[MAX_FILAS, MAX_COLUMNAS];
        private FabricaFormatoCelda fabrica;

        public Hoja(FabricaFormatoCelda fabrica)
        {
            this.fabrica = fabrica;
            GenereCeldas();
        }

        private void GenereCeldas()
        {
            for (int i = 0; i < MAX_FILAS; i++)
            {
                for (int j = 0; j < MAX_COLUMNAS; j++)
                {
                    celdas[i, j] = new Celda((i+1).ToString(), ((char)(j + 65)).ToString(), ObtenerFormatoPorDefecto());
                }

            }
        }

        private FormatoCelda ObtenerFormatoPorDefecto()
        {
            return fabrica.RecuperarFormato("Arial", 12, false);
        }

        internal void EstablecerContenido(string fila, string columna, string contenido)
        {
            int i = int.Parse(fila)-1;
            int j = (int)(char.Parse(columna)) - 65;
            celdas[i, j].Contenido = contenido;
        }

        internal void EstablecerFuente(string fila, string columna, string tipoLetra)
        {
            int i = int.Parse(fila) - 1;
            int j = (int)(char.Parse(columna)) - 65;
            VerificarCeldaExiste(i, j);
            var celda = celdas[i, j];
            var formatoActual = celda.Formato;
            //OJO: Aqui esta el uso principal
            var nuevoFormato = fabrica.RecuperarFormato(tipoLetra, formatoActual.Tamano, formatoActual.EsNegrilla);
            celdas[i, j].Formato = nuevoFormato;
        }
        internal void EstablecerNegrita(string fila, string columna, bool esNegrita)
        {
            int i = int.Parse(fila) - 1;
            int j = (int)(char.Parse(columna)) - 65;
            VerificarCeldaExiste(i, j);
            var celda = celdas[i, j];
            var formatoActual = celda.Formato;
            //OJO: Aqui esta el uso principal
            var nuevoFormato = fabrica.RecuperarFormato(formatoActual.Fuente, formatoActual.Tamano, esNegrita);
            celdas[i, j].Formato = nuevoFormato;
        }
        internal void EstablecerTamano(string fila, string columna, int tamano)
        {
            int i = int.Parse(fila) - 1;
            int j = (int)(char.Parse(columna)) - 65;
            VerificarCeldaExiste(i, j);
            var celda = celdas[i, j];
            var formatoActual = celda.Formato;
            //OJO: Aqui esta el uso principal
            var nuevoFormato = fabrica.RecuperarFormato(formatoActual.Fuente, tamano, formatoActual.EsNegrilla);
            celdas[i, j].Formato = nuevoFormato;
        }

        private void VerificarCeldaExiste(int fila, int columna)
        {
            if (fila < 0 || fila >= MAX_FILAS)
            {
                throw new System.ArgumentException();
            }

            if (columna < 0 || columna >= MAX_COLUMNAS)
            {
                throw new System.ArgumentException();
            }
        }

        internal void Mostrar()
        {
            for (int i = 0; i < MAX_FILAS; i++)
            {
                for (int j = 0; j < MAX_COLUMNAS; j++)
                {
                    celdas[i,j].MostrarCelda();
                }

            }
        }
    }
}
