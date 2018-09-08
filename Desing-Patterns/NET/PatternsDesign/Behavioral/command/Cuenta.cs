using PatternsDesign.Behavioral.memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Behavioral.command
{
    public class Cuenta
    {
        private int Id;
        private double Saldo;
        private Originator Originator;
        private CareTaker CareTaker;

        public Cuenta(int id, double saldo)
        {
            this.Id = id;
            this.Saldo = saldo;
        }

        public Cuenta(int id, double saldo, ref Originator originator, ref CareTaker careTaker)
        {
            this.Id = id;
            this.Saldo = saldo;
            this.CareTaker = careTaker;
            this.Originator = originator;

            this.Originator.setEstado(new Cuenta(this.Id, this.Saldo));
            this.CareTaker.AgregarMomento(this.Originator.Guardar());

        }

        public void Informacion()
        {
            Console.WriteLine($"ID Cuenta {this.Id }");
            Console.WriteLine($"Monto actual {this.Saldo}");
        }

        public void Depositar(double monto)
        {
            this.Saldo += monto;

            this.Originator.setEstado(new Cuenta(this.Id,this.Saldo)); 
            this.CareTaker.AgregarMomento(this.Originator.Guardar());

            Console.WriteLine("Monto Depositado.");
        }

        public void Retirar(double monto)
        {
            this.Saldo -= monto;

            this.Originator.setEstado(new Cuenta(this.Id, this.Saldo));
            this.CareTaker.AgregarMomento(this.Originator.Guardar());

            Console.WriteLine("Monto Retirado.");

        }
    }
}
