using CEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class CDdirectivo
    {
        Cconexion conexion = new Cconexion();
        SqlCommand cmd = new SqlCommand();

        public bool IngresarActualizar_directivo(CEdirectivo e_directivo)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "ingresarActualizar_directivo";
                cmd.Parameters.AddWithValue("@idDirectivo", e_directivo.IdDirectivo);
                cmd.Parameters.AddWithValue("@nombre", e_directivo.Nombre);
                cmd.Parameters.AddWithValue("@apellido", e_directivo.Apellido);
                cmd.Parameters.AddWithValue("@sexo", e_directivo.Sexo);
                cmd.Parameters.AddWithValue("@direccion", e_directivo.Direccion);
                cmd.Parameters.AddWithValue("@telefono", e_directivo.Telefono);
                cmd.Parameters.AddWithValue("@profesion", e_directivo.Profesion);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Eliminar_directivo(CEdirectivo e_directivo)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "eliminar_directivo";
                cmd.Parameters.AddWithValue("@idDirectivo", e_directivo.IdDirectivo);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet Consultar_directivo(CEdirectivo e_directivo)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "consultar_directivo";
                cmd.Parameters.AddWithValue("@nombre", e_directivo.Nombre);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
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
