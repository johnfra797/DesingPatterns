using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural
{
    public class CarroDecorator : ICarro
    {
        private ICarro _carro;

        public CarroDecorator(ICarro aCarro)
        {
            this._carro = aCarro;
        }

        public virtual double GetCost()
        {
            return this._carro.GetCost();
        }

        public virtual string GetDescription()
        {
            return this._carro.GetDescription();
        }
    }
}
