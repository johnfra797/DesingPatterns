using PatternsDesign.Creational.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.abstract_factory
{
    public class Abstract_Factory
    {
        public IFabricaAbstracta GetConexion(FactorysTypes conexion)
        {
            IDictionary<FactorysTypes, IFabricaAbstracta> dict = new Dictionary<FactorysTypes, IFabricaAbstracta>();
            dict.Add(FactorysTypes.BD, new Factory());
            dict.Add(FactorysTypes.SERVICIOS, new FactoryRest());
            IFabricaAbstracta result;
            dict.TryGetValue(conexion, out result);
            return result;
        }
    }
}
