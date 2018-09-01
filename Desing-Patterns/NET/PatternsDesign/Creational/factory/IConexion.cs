using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public interface IConexion
    {
        void conectar();
        void Desconectar();
    }
}
