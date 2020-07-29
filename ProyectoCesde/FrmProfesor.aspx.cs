using CEntidades;
using CReglas;
using System;
using System.Data;
using System.Web;

namespace ProyectoCesde
{
    public partial class FrmProfesor : System.Web.UI.Page
    {
        CRprofesor r_profesor = new CRprofesor();
        CEprofesor e_profesor = new CEprofesor();
        CRconsulta r_consulta = new CRconsulta();

        private void Limpiar()
        {
            txtNombreProf.Text = String.Empty;
            txtApellidoProf.Text = String.Empty;
            txtDocProf.Text = String.Empty;
            txtSexoProf.Text = String.Empty;
            txtDirProf.Text = String.Empty;
            txtTelProf.Text = String.Empty;
            txtAreaProf.Text = String.Empty;
            txtBuscarProf.Text = String.Empty;
        }

        private void Listar_profesores()
        {
            gvProfesores.DataSource = r_consulta.Consultar_tabla("profesor");
            gvProfesores.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_profesores();
            }
        }

        protected void btnAgregarProf_Click(object sender, EventArgs e)
        {
            if (txtDocProf.Text != String.Empty && txtNombreProf.Text != String.Empty && txtApellidoProf.Text != String.Empty && txtSexoProf.Text != String.Empty &&
                txtDirProf.Text != String.Empty && txtTelProf.Text != String.Empty && txtAreaProf.Text != String.Empty)
            {
                e_profesor.IdProfesor = Convert.ToInt32(txtDocProf.Text);
                e_profesor.Nombre = txtNombreProf.Text;
                e_profesor.Apellido = txtApellidoProf.Text;
                e_profesor.Sexo = txtSexoProf.Text;
                e_profesor.Direccion = txtDirProf.Text;
                e_profesor.Telefono = txtTelProf.Text;
                e_profesor.Especialidad = txtAreaProf.Text;

                r_profesor.IngresarActualizar_profesor(e_profesor);
            }

            Limpiar();
            Listar_profesores();
        }

        protected void btnActualProf_Click(object sender, EventArgs e)
        {
            if (txtDocProf.Text != String.Empty && txtNombreProf.Text != String.Empty && txtApellidoProf.Text != String.Empty && txtSexoProf.Text != String.Empty &&
                txtDirProf.Text != String.Empty && txtTelProf.Text != String.Empty && txtAreaProf.Text != String.Empty)
            {
                e_profesor.IdProfesor = Convert.ToInt32(txtDocProf.Text);
                e_profesor.Nombre = txtNombreProf.Text;
                e_profesor.Apellido = txtApellidoProf.Text;
                e_profesor.Sexo = txtSexoProf.Text;
                e_profesor.Direccion = txtDirProf.Text;
                e_profesor.Telefono = txtTelProf.Text;
                e_profesor.Especialidad = txtAreaProf.Text;

                r_profesor.IngresarActualizar_profesor(e_profesor);
            }

            Limpiar();
            Listar_profesores();
        }

        protected void btnEliminarProf_Click(object sender, EventArgs e)
        {
            if (txtDocProf.Text != String.Empty)
            {
                e_profesor.IdProfesor = Convert.ToInt32(txtDocProf.Text);
                r_profesor.Eliminar_profesor(e_profesor);
                Listar_profesores();
            }
            Limpiar();
        }

        protected void btnBuscarProf_Click(object sender, EventArgs e)
        {
            if (txtBuscarProf.Text != String.Empty)
            {
                e_profesor.Nombre = txtBuscarProf.Text;
                DataSet ds = new DataSet();
                ds = r_profesor.Consultar_profesor(e_profesor);
                gvProfesores.DataSource = ds;
                gvProfesores.DataBind();

                if (gvProfesores.Rows.Count > 0)
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
                Listar_profesores();
            }
            Limpiar();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            lblErrorBuscar.Visible = false;
            Listar_profesores();
        }

        protected void gvProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreProf.Text = HttpUtility.HtmlDecode(gvProfesores.SelectedRow.Cells[2].Text);
            txtApellidoProf.Text = HttpUtility.HtmlDecode(gvProfesores.SelectedRow.Cells[3].Text);
            txtDocProf.Text = gvProfesores.SelectedRow.Cells[1].Text;
            txtSexoProf.Text = gvProfesores.SelectedRow.Cells[4].Text;
            txtDirProf.Text = gvProfesores.SelectedRow.Cells[5].Text;
            txtTelProf.Text = gvProfesores.SelectedRow.Cells[6].Text;
            txtAreaProf.Text = HttpUtility.HtmlDecode(gvProfesores.SelectedRow.Cells[7].Text);

            lblErrorBuscar.Visible = false;
        }
    }
}