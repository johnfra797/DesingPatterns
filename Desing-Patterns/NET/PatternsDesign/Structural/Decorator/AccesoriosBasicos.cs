using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural
{
    public class AccesoriosBasicos : CarroDecorator
    {
        public AccesoriosBasicos(ICarro aCarro) : base(aCarro)
        {

        }
        public override string GetDescription()
        {
            return base.GetDescription() + ",paquete de accesorios Basicos.";

        }

        public override double GetCost()
        {
            return base.GetCost() + 2000000.0;
        }
    }
}
