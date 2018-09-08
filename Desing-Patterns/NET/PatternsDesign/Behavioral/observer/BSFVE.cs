using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.observer
{
    public class BSFVE : Observador
    {
        private double Tasa = 35.25;

        public BSFVE(CasaDeCambio casaDeCambio)
        {
            this.casaDeCambio = casaDeCambio;
            this.casaDeCambio.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine($"VEF: {this.casaDeCambio.ObtenerEstado() * this.Tasa}");
        }
    }
}
