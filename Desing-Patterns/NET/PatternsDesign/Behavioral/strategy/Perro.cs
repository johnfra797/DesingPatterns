using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.strategy
{
    public class Perro : IAnimal
    {
        public void accion()
        {
            Console.WriteLine("GUAU GUAU");
        }
    }
}
