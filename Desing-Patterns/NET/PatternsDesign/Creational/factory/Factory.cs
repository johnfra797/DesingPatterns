using PatternsDesign.Creational.abstract_factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public class Factory : IFabricaAbstracta
    {
        public ILeer GetREST(TiposServicios pTipoServicios)
        {
            throw new NotImplementedException();
        }

        public IConexion GetBD(Conexiones conexion)
        {
            IDictionary<Conexiones, IConexion> dict = new Dictionary<Conexiones, IConexion>();
            dict.Add(Conexiones.SQL, new SQL());
            dict.Add(Conexiones.Mongo, new Mongo());
            IConexion result;
            dict.TryGetValue(conexion, out result);
            return result;
        }
        /*
        public IConexion GetConexion(Conexiones conexion)
        {
            IDictionary<Conexiones, IConexion> dict = new Dictionary<Conexiones, IConexion>();
            dict.Add(Conexiones.SQL, new SQL());
            dict.Add(Conexiones.Mongo, new Mongo());
            IConexion result;
            dict.TryGetValue(conexion, out result);
            return result;
        }*/
    }
}
