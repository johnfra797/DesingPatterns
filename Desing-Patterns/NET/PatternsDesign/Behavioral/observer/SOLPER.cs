using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.observer
{
    public class SOLPER : Observador
    {
        private double Tasa = 3.25;

        public SOLPER(CasaDeCambio casaDeCambio)
        {
            this.casaDeCambio = casaDeCambio;
            this.casaDeCambio.AgregarObservador(this);
        }

        public override void Actualizar()
        {
            Console.WriteLine($"PER: {this.casaDeCambio.ObtenerEstado() * this.Tasa}");
        }
    }
}
