using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.Proxy
{
    public class Dolar : IPrecio
    {
        public double GetPrecio()
        {
            Random precio = new Random();

            return precio.Next(1, 9999);
        }
    }
}
