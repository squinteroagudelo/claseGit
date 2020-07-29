using CEntidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class CDestudiante
    {
        Cconexion conexion = new Cconexion();
        SqlCommand cmd = new SqlCommand();

        public bool IngresarActualizar_estudiante(CEestudiante e_estudiante)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "ingresarActualizar_estudiante";
                cmd.Parameters.AddWithValue("@idEstudiante", e_estudiante.IdEstudiante);
                cmd.Parameters.AddWithValue("@nombre", e_estudiante.Nombre);
                cmd.Parameters.AddWithValue("@apellido", e_estudiante.Apellido);
                cmd.Parameters.AddWithValue("@sexo", e_estudiante.Sexo);
                cmd.Parameters.AddWithValue("@direccion", e_estudiante.Direccion);
                cmd.Parameters.AddWithValue("@telefono", e_estudiante.Telefono);
                cmd.Parameters.AddWithValue("@fechaNacimiento", e_estudiante.FechaNacimiento);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Eliminar_estudiante(CEestudiante e_estudiante)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "eliminar_estudiante";
                cmd.Parameters.AddWithValue("@idEstudiante", e_estudiante.IdEstudiante);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataSet Consultar_estudiante(CEestudiante e_estudiante)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion.Conectar("BDCesde");
                cmd.CommandText = "consultar_estudiante";
                cmd.Parameters.AddWithValue("@nombre", e_estudiante.Nombre);
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
