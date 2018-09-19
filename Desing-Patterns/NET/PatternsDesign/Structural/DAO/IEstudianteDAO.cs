using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.DAO
{
    public interface IEstudianteDAO : ICRUD<Estudiante>
    {
        List<Estudiante> ObtenerEstudianteXEdad(int edad);

    }
}
