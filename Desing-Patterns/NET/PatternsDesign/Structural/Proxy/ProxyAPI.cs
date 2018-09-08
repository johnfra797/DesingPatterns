using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.Proxy
{
    public class ProxyAPI
    {
        IPrecio iPrecio;

        public double GetPrecioDolar()
        {
            iPrecio = new Dolar();

            return iPrecio.GetPrecio();
        }
    }
}
