using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.memento
{
    public class CareTaker
    {
        private List<Momento> ListaMomentos = new List<Momento>();

        public void AgregarMomento(Momento momento)
        {
            this.ListaMomentos.Add(momento);
        }

        public Momento ObtenerMomento(int index)
        {
            return this.ListaMomentos.GetRange(index,1).FirstOrDefault();
        }
    }
}
