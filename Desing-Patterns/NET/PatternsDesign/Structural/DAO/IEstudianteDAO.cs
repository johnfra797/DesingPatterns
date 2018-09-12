using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.DAO
{
    interface IEstudianteDAO
    {

        List<Estudiante> ObtenerTodos();
        List<Estudiante> ObtenerEstudianteXEdad(int edad);
        void actualizarEstudiante(Estudiante estudiante);
        void borrarEstudiante(Estudiante estudiante);
        void AgregarEstudiante(Estudiante estudiante);

    }
}
