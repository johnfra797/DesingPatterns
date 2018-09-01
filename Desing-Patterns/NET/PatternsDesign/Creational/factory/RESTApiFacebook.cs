using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public class RESTApiFacebook : ILeer
    {
       
        public void Leer()
        {
            Console.WriteLine("Leyendo api FACEBOOK");
        }
    }
}
