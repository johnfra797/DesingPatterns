using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural
{
    public class AccesoriosAvanzados : CarroDecorator
    {
        public AccesoriosAvanzados(ICarro aCarro) : base(aCarro)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",paquete de accesorios Avanzados.";

        }

        public override double GetCost()
        {
            return base.GetCost() + 5000000.0;
        }
    }
}
