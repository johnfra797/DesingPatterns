using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.builder.builderII
{
    public interface IAutomovilBuilder
    {
        void BuildTipo();
        void BuildCaja();
        void BuildEstilo();
        Automovil Auto { get; }
    }
}
