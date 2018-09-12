using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.DAO
{
    public class Estudiante
    {
        private string Nombre;
        private int Edad;
        public Estudiante(string nombre,int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }


        public String getNombre()
        {
            return Nombre;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public int getEdad()
        {
            return Edad;
        }

        public void setEdad(int edad)
        {
            this.Edad = edad;
        }
    }
}
