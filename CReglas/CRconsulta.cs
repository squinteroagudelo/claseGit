using CDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CReglas
{
    public class CRconsulta
    {
        CDconsulta d_consulta = new CDconsulta();

        public DataSet Consultar_tabla(String tabla)
        {
            return d_consulta.Consultar_tabla(tabla);
        }
    }
}
