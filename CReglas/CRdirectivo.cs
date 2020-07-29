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
    public class CRdirectivo
    {
        CDdirectivo d_directivo = new CDdirectivo();

        public bool IngresarActualizar_directivo(CEdirectivo e_directivo)
        {
            return d_directivo.IngresarActualizar_directivo(e_directivo);
        }

        public bool Eliminar_directivo(CEdirectivo e_directivo)
        {
            return d_directivo.Eliminar_directivo(e_directivo);
        }

        public DataSet Consultar_directivo(CEdirectivo e_directivo)
        {
            return d_directivo.Consultar_directivo(e_directivo);
        }
    }
}
