using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public enum Conexiones
    {
        Mongo,
        SQL
    };

    public enum TiposServicios
    {
        REST,
        SOAP
    };
}
