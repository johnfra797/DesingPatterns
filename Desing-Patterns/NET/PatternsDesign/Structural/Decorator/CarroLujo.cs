using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural
{
    public class CarroLujo : ICarro
    {
        public double GetCost()
        {
            return 60000000;
        }

        public string GetDescription()
        {
            return "Carro de lujo.";
        }
    }
}
