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
    public class CRestudiante
    {
        CDestudiante d_estudiante = new CDestudiante();
        
        public bool IngresarActualizar_estudiante(CEestudiante e_estudiante)
        {
            return d_estudiante.IngresarActualizar_estudiante(e_estudiante);
        }

        public bool Eliminar_estudiante(CEestudiante e_estudiante)
        {
            return d_estudiante.Eliminar_estudiante(e_estudiante);
        }

        public DataSet Consultar_estudiante(CEestudiante e_estudiante)
        {
            return d_estudiante.Consultar_estudiante(e_estudiante);
        }
    }
}
