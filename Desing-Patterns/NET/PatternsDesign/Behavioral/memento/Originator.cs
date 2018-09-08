using PatternsDesign.Behavioral.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.memento
{
    public class Originator
    {
        private Cuenta Estado;

        public void setEstado(Cuenta cuenta)
        {
            this.Estado = cuenta;
        }

        public Cuenta getEstado()
        {
            return this.Estado;
        }

        public Momento Guardar()
        {
            return new Momento(this.Estado);
        }

        public void Restaurar(Momento momento)
        {
            this.Estado = momento.ObtenerMomento();
        }
    }
}
