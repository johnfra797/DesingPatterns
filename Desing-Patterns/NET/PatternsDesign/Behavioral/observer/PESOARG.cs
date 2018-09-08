using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.observer
{
    public class PESOARG : Observador
    {
        private double Tasa = 19.07;

        public PESOARG(CasaDeCambio casaDeCambio)
        {
            this.casaDeCambio = casaDeCambio;
            this.casaDeCambio.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine($"ARG: {this.casaDeCambio.ObtenerEstado() * this.Tasa}");
        }
    }
}
