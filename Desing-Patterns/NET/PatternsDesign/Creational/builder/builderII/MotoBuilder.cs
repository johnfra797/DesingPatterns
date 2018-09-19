using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.builder.builderII
{
    public class MotoBuilder : IAutomovilBuilder
    {
        Automovil automovil;

        public MotoBuilder()
        {
            automovil = new Automovil("Moto");
        }

        public void BuildTipo()
        {
            automovil.Tipo = Tipo.Moto;
        }

        public void BuildCaja()
        {
            automovil.Caja = Caja.Sincronica;
        }

        public void BuildEstilo()
        {
            automovil.Estilo = Estilo.Economico;
        }

        public Automovil Auto
        {
            get { return automovil; }
        }
    }
}
