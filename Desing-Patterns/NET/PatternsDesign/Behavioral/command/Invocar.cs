using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.command
{
    public class Invocar
    {
        private List<IOperacion> ListaOperaciones = new List<IOperacion>();

        public void RecibirOperacion(IOperacion operacion)
        {
            this.ListaOperaciones.Add(operacion);
        }

        public void EjecutarOperaciones()
        {
            this.ListaOperaciones.ForEach(x=>x.Ejecutar());
            this.ListaOperaciones.Clear();
        }
    }
}
