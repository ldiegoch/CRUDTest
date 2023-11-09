using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDTest
{
    public partial class Categories : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            /*Empleado entidad = new Empleado()
            {
                IdEmpleado = idEmpleado,
                NombreCompleto = txtNombreCompleto.Text,
                Departamento = new Departamento() { IdDepartamento = Convert.ToInt32(ddlDepartamento.SelectedValue) },
                Sueldo = Convert.ToDecimal(txtSueldo.Text, new CultureInfo("es-PE")),
                FechaContrato = txtFechaContrato.Text
            };

            bool respuesta;

            if (idEmpleado != 0)
                respuesta = empleadoBL.Editar(entidad);
            else
                respuesta = empleadoBL.Crear(entidad);

            if (respuesta)
                Response.Redirect("~/Default.aspx");
            else*/
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('No se pudo realizar la operacion')", true);
        }
    }
}