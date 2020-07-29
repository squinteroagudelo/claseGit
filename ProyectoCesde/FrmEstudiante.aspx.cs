using CEntidades;
using CReglas;
using System;
using System.Data;
using System.Web;

namespace ProyectoCesde
{
    public partial class FrmEstudiante : System.Web.UI.Page
    {
        CRconsulta r_consulta = new CRconsulta();
        CEestudiante e_estudiante = new CEestudiante();
        CRestudiante r_estudiante = new CRestudiante();
        
        private void Limpiar()
        {
            txtNombreEst.Text = String.Empty;
            txtApellidoEst.Text = String.Empty;
            txtDocEst.Text = String.Empty;
            txtSexoEst.Text = String.Empty;
            txtDirEst.Text = String.Empty;
            txtTelEst.Text = String.Empty;
            txtFechaNac.Text = String.Empty;
            txtBuscarEst.Text = String.Empty;
        }

        private void Listar_estudiantes()
        {
            gvEstudiantes.DataSource = r_consulta.Consultar_tabla("estudiante");
            gvEstudiantes.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_estudiantes(); 
            }
        }

        protected void btnAgregarEst_Click(object sender, EventArgs e)
        {
            if (txtDocEst.Text != String.Empty && txtNombreEst.Text != String.Empty && txtApellidoEst.Text != String.Empty && txtSexoEst.Text != String.Empty &&
                txtDirEst.Text != String.Empty && txtTelEst.Text != String.Empty && txtFechaNac.Text != String.Empty)
            {
                e_estudiante.IdEstudiante = Convert.ToInt32(txtDocEst.Text);
                e_estudiante.Nombre = txtNombreEst.Text;
                e_estudiante.Apellido = txtApellidoEst.Text;
                e_estudiante.Sexo = txtSexoEst.Text;
                e_estudiante.Direccion = txtDirEst.Text;
                e_estudiante.Telefono = txtTelEst.Text;
                e_estudiante.FechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);

                r_estudiante.IngresarActualizar_estudiante(e_estudiante);
            }

            Limpiar();
            Listar_estudiantes();
        }

        protected void gvEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreEst.Text = HttpUtility.HtmlDecode(gvEstudiantes.SelectedRow.Cells[2].Text);
            txtApellidoEst.Text = HttpUtility.HtmlDecode(gvEstudiantes.SelectedRow.Cells[3].Text);
            txtDocEst.Text = gvEstudiantes.SelectedRow.Cells[1].Text;
            txtSexoEst.Text = gvEstudiantes.SelectedRow.Cells[4].Text;
            txtDirEst.Text = gvEstudiantes.SelectedRow.Cells[5].Text;
            txtTelEst.Text = gvEstudiantes.SelectedRow.Cells[6].Text;
            txtFechaNac.Text = Convert.ToDateTime(gvEstudiantes.SelectedRow.Cells[7].Text).ToString("dd-MMMM-yyyy");
        }

        protected void btnActualEst_Click(object sender, EventArgs e)
        {
            if (txtDocEst.Text != String.Empty && txtNombreEst.Text != String.Empty && txtApellidoEst.Text != String.Empty && txtSexoEst.Text != String.Empty &&
                txtDirEst.Text != String.Empty && txtTelEst.Text != String.Empty && txtFechaNac.Text != String.Empty)
            {
                e_estudiante.IdEstudiante = Convert.ToInt32(txtDocEst.Text);
                e_estudiante.Nombre = txtNombreEst.Text;
                e_estudiante.Apellido = txtApellidoEst.Text;
                e_estudiante.Sexo = txtSexoEst.Text;
                e_estudiante.Direccion = txtDirEst.Text;
                e_estudiante.Telefono = txtTelEst.Text;
                e_estudiante.FechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);

                r_estudiante.IngresarActualizar_estudiante(e_estudiante);
            }

            Limpiar();
            Listar_estudiantes();
        }

        protected void btnEliminarEst_Click(object sender, EventArgs e)
        {
            if (txtDocEst.Text != String.Empty)
            {
                e_estudiante.IdEstudiante = Convert.ToInt32(txtDocEst.Text);
                r_estudiante.Eliminar_estudiante(e_estudiante);
                Listar_estudiantes();
            }
            Limpiar();
        }

        protected void btnBuscarEst_Click(object sender, EventArgs e)
        {
            if(txtBuscarEst.Text != String.Empty)
            {
                e_estudiante.Nombre = txtBuscarEst.Text;
                DataSet ds = new DataSet();
                ds = r_estudiante.Consultar_estudiante(e_estudiante);
                gvEstudiantes.DataSource = ds;
                gvEstudiantes.DataBind();

                if (gvEstudiantes.Rows.Count > 0)
                {
                    lblErrorBuscar.Visible = false;
                }
                else
                {
                    lblErrorBuscar.Text = "Sin registros";
                    lblErrorBuscar.Visible = true;
                }
            }
            else
            {
                lblErrorBuscar.Visible = false;
                Listar_estudiantes();
            }
            Limpiar();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            lblErrorBuscar.Visible = false;
            Listar_estudiantes();
        }
    }
}