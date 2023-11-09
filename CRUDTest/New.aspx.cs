using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CRUDTest.Repositories;

namespace CRUDTest
{
    public partial class New : System.Web.UI.Page
    {
        private CategoryRepository categoryRepository;
        private int idCategory = 0;

        public New() {
            categoryRepository = new CategoryRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idEmpleado"] != null)
                {
                    idCategory = Convert.ToInt32(Request.QueryString["idCategory"].ToString());

                    if (idCategory != 0)
                    {
                       loadCategory(idCategory);
                    }
                    else
                    {
                        lblTitulo.Text = "Nueva Categoria";
                        btnSubmit.Text = "Guardar";
                    }
                }
                else
                {
                    prepareNewCategory();
                }
            }
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

        private void loadCategory(int categoryId)
        {
            lblTitulo.Text = "Editar Categoria";
            btnSubmit.Text = "Actualizar";

            /*Category category = categoryRepository.Obtener(idEmpleado);
            txtNombreCompleto.Text = empleado.NombreCompleto;
            CargarDepartamentos(empleado.Departamento.IdDepartamento.ToString());
            txtSueldo.Text = empleado.Sueldo.ToString();
            txtFechaContrato.Text = Convert.ToDateTime(empleado.FechaContrato, new CultureInfo("es-PE")).ToString("yyyy-MM-dd");
            */
        }

        private void prepareNewCategory()
        {
            lblTitulo.Text = "Nueva Categoria";
            btnSubmit.Text = "Guardar";
        }
    }
}