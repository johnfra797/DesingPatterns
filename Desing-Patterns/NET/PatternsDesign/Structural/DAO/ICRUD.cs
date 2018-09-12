using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural.DAO
{
    public interface ICRUD<T>
    {

        List<T> ObtenerTodos();
        void actualizar(T t);
        void borrar(T t);
        void Agregar(T t);

    }
}
