using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class CDconsulta
    {
        Cconexion conexion = new Cconexion();
        SqlCommand cmd = new SqlCommand();

        public DataSet Consultar_tabla(string tabla)
        {
            try
            {
                string stm = "select * from " + tabla;
                SqlDataAdapter da = new SqlDataAdapter(stm, conexion.Conectar("BDCesde"));
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
