using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Creational.builder.builderII
{
    public class Automovil
    {
        string automovilMarca;
        Tipo tipo;
        Caja caja;
        Estilo estilo;

        public Automovil(string marca)
        {
            automovilMarca = marca;
        }



        public string AutomovilMarca
        {
            get { return automovilMarca; }
        }

        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public Caja Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public Estilo Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }
        
        public override string ToString()
        {
            return string.Format("Marca: {0}\nTipo: {1}\nCaja {2}\nEstilo: {3}",
                AutomovilMarca, Tipo, Caja, Estilo);
        }
    }
}
