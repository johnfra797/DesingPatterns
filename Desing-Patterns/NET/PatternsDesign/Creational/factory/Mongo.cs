using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public class Mongo : IConexion
    {
        public void conectar()
        {
            Console.WriteLine("MONGO CONECTADO");
        }

        public void Desconectar()
        {
            Console.WriteLine("MONGO DESCONECTADO");
        }
    }
}
