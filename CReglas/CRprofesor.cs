using CDatos;
using CEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CReglas
{
    public class CRprofesor
    {
        CDprofesor d_profesor = new CDprofesor();

        public bool IngresarActualizar_profesor(CEprofesor e_profesor)
        {
            return d_profesor.IngresarActualizar_profesor(e_profesor);
        }

        public bool Eliminar_profesor(CEprofesor e_profesor)
        {
            return d_profesor.Eliminar_profesor(e_profesor);
        }

        public DataSet Consultar_profesor(CEprofesor e_profesor)
        {
            return d_profesor.Consultar_profesor(e_profesor);
        }
    }
}
