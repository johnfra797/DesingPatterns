using PatternsDesign.Behavioral.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.memento
{
    public class Momento
    {
        private Cuenta cuentaMomento;

        public Momento(Cuenta cuenta)
        {
            this.cuentaMomento = cuenta;
        }

        public Cuenta ObtenerMomento()
        {
            return this.cuentaMomento;
        }
    }
}
