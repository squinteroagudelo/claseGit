using CEntidades;
using CReglas;
using System;
using System.Data;
using System.Web;

namespace ProyectoCesde
{
    public partial class FrmDirectivo : System.Web.UI.Page
    {
        CRdirectivo r_directivo = new CRdirectivo();
        CEdirectivo e_directivo = new CEdirectivo();
        CRconsulta r_consulta = new CRconsulta();

        private void Limpiar()
        {
            txtNombreDirect.Text = String.Empty;
            txtApellidoDirect.Text = String.Empty;
            txtDocDirect.Text = String.Empty;
            txtSexoDirect.Text = String.Empty;
            txtDirDirect.Text = String.Empty;
            txtTelDirect.Text = String.Empty;
            txtProfesion.Text = String.Empty;
            txtBuscarDirect.Text = String.Empty;
        }

        private void Listar_directivos()
        {
            gvDirectivos.DataSource = r_consulta.Consultar_tabla("directivo");
            gvDirectivos.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_directivos();
            }
        }

        protected void btnAgregarDirect_Click(object sender, EventArgs e)
        {
            if (txtDocDirect.Text != String.Empty && txtNombreDirect.Text != String.Empty && txtApellidoDirect.Text != String.Empty && txtSexoDirect.Text != String.Empty &&
                txtDirDirect.Text != String.Empty && txtTelDirect.Text != String.Empty && txtProfesion.Text != String.Empty)
            {
                e_directivo.IdDirectivo = Convert.ToInt32(txtDocDirect.Text);
                e_directivo.Nombre = txtNombreDirect.Text;
                e_directivo.Apellido = txtApellidoDirect.Text;
                e_directivo.Sexo = txtSexoDirect.Text;
                e_directivo.Direccion = txtDirDirect.Text;
                e_directivo.Telefono = txtTelDirect.Text;
                e_directivo.Profesion = txtProfesion.Text;

                r_directivo.IngresarActualizar_directivo(e_directivo);
            }

            Limpiar();
            Listar_directivos();
        }

        protected void btnActualDirect_Click(object sender, EventArgs e)
        {
            if (txtDocDirect.Text != String.Empty && txtNombreDirect.Text != String.Empty && txtApellidoDirect.Text != String.Empty && txtSexoDirect.Text != String.Empty &&
                txtDirDirect.Text != String.Empty && txtTelDirect.Text != String.Empty && txtProfesion.Text != String.Empty)
            {
                e_directivo.IdDirectivo = Convert.ToInt32(txtDocDirect.Text);
                e_directivo.Nombre = txtNombreDirect.Text;
                e_directivo.Apellido = txtApellidoDirect.Text;
                e_directivo.Sexo = txtSexoDirect.Text;
                e_directivo.Direccion = txtDirDirect.Text;
                e_directivo.Telefono = txtTelDirect.Text;
                e_directivo.Profesion = txtProfesion.Text;

                r_directivo.IngresarActualizar_directivo(e_directivo);
            }

            Limpiar();
            Listar_directivos();
        }

        protected void btnEliminarDirect_Click(object sender, EventArgs e)
        {
            if (txtDocDirect.Text != String.Empty)
            {
                e_directivo.IdDirectivo = Convert.ToInt32(txtDocDirect.Text);
                r_directivo.Eliminar_directivo(e_directivo);
                Listar_directivos();
            }
            Limpiar();
        }

        protected void btnBuscarDirect_Click(object sender, EventArgs e)
        {
            if (txtBuscarDirect.Text != String.Empty)
            {
                e_directivo.Nombre = txtBuscarDirect.Text;
                DataSet ds = new DataSet();
                ds = r_directivo.Consultar_directivo(e_directivo);
                gvDirectivos.DataSource = ds;
                gvDirectivos.DataBind();

                if (gvDirectivos.Rows.Count > 0)
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
                Listar_directivos();
            }
            Limpiar();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            lblErrorBuscar.Visible = false;
            Listar_directivos();
        }

        protected void gvDirectivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreDirect.Text = HttpUtility.HtmlDecode(gvDirectivos.SelectedRow.Cells[2].Text);
            txtApellidoDirect.Text = HttpUtility.HtmlDecode(gvDirectivos.SelectedRow.Cells[3].Text);
            txtDocDirect.Text = gvDirectivos.SelectedRow.Cells[1].Text;
            txtSexoDirect.Text = gvDirectivos.SelectedRow.Cells[4].Text;
            txtDirDirect.Text = gvDirectivos.SelectedRow.Cells[5].Text;
            txtTelDirect.Text = gvDirectivos.SelectedRow.Cells[6].Text;
            txtProfesion.Text = HttpUtility.HtmlDecode(gvDirectivos.SelectedRow.Cells[7].Text);

            lblErrorBuscar.Visible = false;
        }
    }
}