using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.strategy
{
    public class Gato : IAnimal
    {
        public void accion()
        {
            Console.WriteLine("MIAU MIAU");
        }
    }
}
