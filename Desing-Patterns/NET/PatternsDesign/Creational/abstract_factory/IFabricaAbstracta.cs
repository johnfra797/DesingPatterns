using PatternsDesign.Creational.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.abstract_factory
{
    public interface IFabricaAbstracta
    {
        IConexion GetBD(Conexiones conexion);
        ILeer GetREST(TiposServicios pTipoServicios);
    }
}
