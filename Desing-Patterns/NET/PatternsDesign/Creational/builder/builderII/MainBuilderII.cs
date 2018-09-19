using PatternsDesign.Creational.builder.builderII;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.builder
{
    public class MainBuilderII
    {
        public MainBuilderII()
        {
            ManufacturerAutomovil newManufacturer = new ManufacturerAutomovil();
            
            IAutomovilBuilder automovilBuilder = null;

            automovilBuilder = new CarroBuilder();
            newManufacturer.Construct(automovilBuilder);
            Console.WriteLine("A new Automovil built:\n\n{0}", automovilBuilder.Auto.ToString());

            automovilBuilder = new MotoBuilder();
            newManufacturer.Construct(automovilBuilder);
            Console.WriteLine("A new Automovil built:\n\n{0}", automovilBuilder.Auto.ToString());
        }
    }
}
