using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.factory
{
    public class SQL : IConexion
    {
        public void conectar()
        {
            Console.WriteLine("SQL CONECTADO");
        }

        public void Desconectar()
        {
            Console.WriteLine("SQL DESCONECTADO");
        }
    }
}
