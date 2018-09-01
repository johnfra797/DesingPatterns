using PatternsDesign.Creational.abstract_factory;
using PatternsDesign.Creational.factory;
using PatternsDesign.singleton;
using PatternsDesign.strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign
{
    class Program
    {

        static void Main(string[] args)
        {
            //    MainStrategy mainStrategy = new MainStrategy();

            //    var instanc = SingletonInstancia.GetInstancia();

            //    SingletonInstancia.GetInstancia();

            var factoryAbstract = new Abstract_Factory();
            var instanciaBD = factoryAbstract.GetConexion(FactorysTypes.BD);
            var instanciaSERVICIOS = factoryAbstract.GetConexion(FactorysTypes.SERVICIOS);
            //Factory factory = new Factory();
            instanciaBD.GetBD(Conexiones.SQL).conectar();
            instanciaBD.GetBD(Conexiones.Mongo).conectar();

            instanciaSERVICIOS.GetREST(TiposServicios.REST).Leer();
            instanciaSERVICIOS.GetREST(TiposServicios.SOAP).Leer();
            Console.ReadKey();
        }
    }
}
