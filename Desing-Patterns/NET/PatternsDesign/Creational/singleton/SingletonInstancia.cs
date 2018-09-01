using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.singleton
{
    public  class SingletonInstancia
    {
        private static SingletonInstancia instancia;

        private SingletonInstancia()
        {

        }

        public static SingletonInstancia GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new SingletonInstancia();
            }

            return instancia;
        }
    }
}
