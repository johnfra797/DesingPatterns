using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural
{
    public class CarroEconomico : ICarro
    {
        public double GetCost()
        {
            return 30000000;
        }

        public string GetDescription()
        {
            return "Carro Economico.";
        }
    }
}
