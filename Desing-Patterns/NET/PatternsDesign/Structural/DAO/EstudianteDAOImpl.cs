using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.DAO
{
    public class EstudianteDAOImpl : IEstudianteDAO
    {
        List<Estudiante> estudiantes;

        public EstudianteDAOImpl()
        {
            estudiantes = new List<Estudiante>();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            this.estudiantes.Add(estudiante);
            Console.WriteLine($"Estudiante {estudiante.getNombre()} agregado correctamente.");
        }

        public void actualizarEstudiante(Estudiante estudiante)
        {
            this.estudiantes.Remove(estudiante);
            this.estudiantes.Add(estudiante);
            Console.WriteLine($"Estudiante {estudiante.getNombre()} actualizado correctamente.");
        }

        public void borrarEstudiante(Estudiante estudiante)
        {
            this.estudiantes.Remove(estudiante);
            Console.WriteLine($"Estudiante {estudiante.getNombre()} eliminado correctamente.");
        }

        public List<Estudiante> ObtenerEstudianteXEdad(int edad)
        {
            Console.Write($"Total de estudiantes de edad {edad}");
            return this.estudiantes.Where(x => x.getEdad() == edad).ToList();
        }

        public List<Estudiante> ObtenerTodos()
        {
            Console.Write($"Total de estudiantes registrados {this.estudiantes.Count}");
            return this.estudiantes;
        }
    }
}
