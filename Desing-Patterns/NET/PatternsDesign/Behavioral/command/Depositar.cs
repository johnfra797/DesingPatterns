using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.command
{
    public class Depositar : IOperacion
    {
        private Cuenta CuentaObj;
        private double Monto;

        public Depositar(Cuenta cuenta,double monto)
        {
            this.CuentaObj = cuenta;
            this.Monto = monto;
        }
        
        public void Ejecutar()
        {
            this.CuentaObj.Depositar(this.Monto);
        }
    }
}
