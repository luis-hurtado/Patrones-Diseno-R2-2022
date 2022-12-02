using Factory_Method.Cobra;

using System;
using System.Collections.Generic;

namespace Factory_Method
{
    internal abstract class Controlador
    {
        public void Renderizar(string nombreVista, IDictionary<string, object> contexto)
        {
            var motor = FabricarMotorVista();
            var html = motor.Renderizar(nombreVista, contexto);
            Console.WriteLine(html);
        }

        protected abstract IMotorVista FabricarMotorVista();

        //protected virtual IMotorVista FabricarMotorVista()
        //{
        //    return new MotorVistaCobra();
        //}
    }
}
