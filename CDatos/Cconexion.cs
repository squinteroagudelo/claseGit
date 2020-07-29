using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class Cconexion
    {
        public SqlConnection Conectar(string Cnx)
        {
            try 
            {

                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[Cnx].ToString());
                oconectar.Open();                          
                return oconectar;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
