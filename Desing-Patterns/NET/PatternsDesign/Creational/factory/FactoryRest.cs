using PatternsDesign.Creational.abstract_factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public class FactoryRest : IFabricaAbstracta
    {
        public IConexion GetBD(Conexiones conexion)
        {
            throw new NotImplementedException();
        }
        
        public ILeer GetREST(TiposServicios pTipoServicios)
        {
            IDictionary<TiposServicios, ILeer> dict = new Dictionary<TiposServicios, ILeer>();
            dict.Add(TiposServicios.REST, new RESTApiFacebook());
            dict.Add(TiposServicios.SOAP, new RESTApiGoogle());
            ILeer result;
            dict.TryGetValue(pTipoServicios, out result);
            return result;
        }
    }
}
