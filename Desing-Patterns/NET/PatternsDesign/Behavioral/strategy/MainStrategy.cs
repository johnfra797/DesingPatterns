using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.strategy
{
   
    public class MainStrategy
    {
        private IAnimal animal { get; set; }
        public MainStrategy()
        {
            IAnimal perro = new Perro();
            IAnimal gato = new Gato();

            perro.accion();
            gato.accion();

        }

    }
}
