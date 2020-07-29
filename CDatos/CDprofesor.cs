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
    public class CDprofesor
    {
        Cconexion conexion = new Cconexion();
        SqlCommand cmd = new SqlCommand();

        public bool IngresarActualizar_profesor(CEprofesor e_profesor)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "ingresarActualizar_profesor";
                cmd.Parameters.AddWithValue("@idProfesor", e_profesor.IdProfesor);
                cmd.Parameters.AddWithValue("@nombre", e_profesor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", e_profesor.Apellido);
                cmd.Parameters.AddWithValue("@sexo", e_profesor.Sexo);
                cmd.Parameters.AddWithValue("@direccion", e_profesor.Direccion);
                cmd.Parameters.AddWithValue("@telefono", e_profesor.Telefono);
                cmd.Parameters.AddWithValue("@especialidad", e_profesor.Especialidad);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Eliminar_profesor(CEprofesor e_profesor)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "eliminar_profesor";
                cmd.Parameters.AddWithValue("@idProfesor", e_profesor.IdProfesor);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet Consultar_profesor(CEprofesor e_profesor)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "consultar_profesor";
                cmd.Parameters.AddWithValue("@nombre", e_profesor.Nombre);
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
