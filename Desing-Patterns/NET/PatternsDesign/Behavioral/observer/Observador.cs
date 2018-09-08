using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.observer
{
    public abstract class Observador
    {
        public  CasaDeCambio casaDeCambio;
        public abstract void Actualizar();
    }
}
