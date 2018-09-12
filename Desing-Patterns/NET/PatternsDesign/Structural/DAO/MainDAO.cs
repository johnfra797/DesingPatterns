using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.DAO
{
    public class MainDAO
    {
        public MainDAO()
        {
            IEstudianteDAO estudianteDAO = new EstudianteDAOImpl();

            estudianteDAO.AgregarEstudiante(new Estudiante("Marc Anthony",50));
            estudianteDAO.AgregarEstudiante(new Estudiante("JDCG", 29));
            estudianteDAO.AgregarEstudiante(new Estudiante("Ramon Castillo", 70));



            estudianteDAO.ObtenerTodos().ForEach(x=>Console.WriteLine($"{x.getNombre()} {x.getEdad()}"));

            estudianteDAO.borrarEstudiante(new Estudiante("JDCG", 29));

            estudianteDAO.ObtenerTodos().ForEach(x => Console.WriteLine($"{x.getNombre()} {x.getEdad()}"));

            estudianteDAO.ObtenerEstudianteXEdad(70).ForEach(x => Console.WriteLine($"{x.getNombre()} {x.getEdad()}"));

            var estudianteMarc = new Estudiante("Marc Anthony", 50);
            estudianteMarc.setEdad(51);
            estudianteMarc.setNombre("Marc Anthony.");
            estudianteDAO.actualizarEstudiante(estudianteMarc);

            estudianteDAO.ObtenerTodos().ForEach(x => Console.WriteLine($"{x.getNombre()} {x.getEdad()}"));

        }
    }
}
