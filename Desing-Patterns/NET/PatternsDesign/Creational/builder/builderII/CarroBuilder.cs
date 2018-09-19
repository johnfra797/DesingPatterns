using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.builder.builderII
{
    public class CarroBuilder : IAutomovilBuilder
    {
        Automovil automovil;

        public CarroBuilder()
        {
            automovil = new Automovil("Carro");
        }
        
        public void BuildTipo()
        {
            automovil.Tipo = Tipo.Carro;
        }

        public void BuildCaja()
        {
            automovil.Caja = Caja.Automatica;
        }

        public void BuildEstilo()
        {
            automovil.Estilo = Estilo.Lujo;
        }
        
        public Automovil Auto
        {
            get { return automovil; }
        }
    }
}
