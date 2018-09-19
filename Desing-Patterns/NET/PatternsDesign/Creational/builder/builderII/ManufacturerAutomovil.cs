using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.builder.builderII
{
    public class ManufacturerAutomovil
    {
        public void Construct(IAutomovilBuilder automovilBuilder)
        {
            automovilBuilder.BuildCaja();
            automovilBuilder.BuildEstilo();
            automovilBuilder.BuildTipo();
        }
    }
}
