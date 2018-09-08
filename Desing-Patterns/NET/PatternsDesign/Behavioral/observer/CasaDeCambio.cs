using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.observer
{
    public class CasaDeCambio
    {
        private List<Observador> observadores = new List<Observador>();
        private int Estado;

        public int ObtenerEstado()
        {
            return this.Estado;
        }

        public void SetEstado(int estado)
        {
            this.Estado = estado;
            this.NotificarTodosObservadores();
        }

        public void AgregarObservador(Observador observador)
        {
            this.observadores.Add(observador);
        }

        public void NotificarTodosObservadores()
        {
            this.observadores.ForEach(x=>x.Actualizar());
        }
    }
}
