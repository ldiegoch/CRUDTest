using CRUDTest.Models;
using CRUDTest.Repositories;
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
    public partial class Categories : Page
    {
        CategoryRepository categoryRepository;
        List<Category> categories { get; set; }

        public Categories()
        {
            categoryRepository = new CategoryRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Category> categories = categoryRepository.GetCategories();
                Category firstCategory = categories[0];

                CategoriesGrid.DataSource = categories;
                CategoriesGrid.DataBind();
            }
        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            /*LinkButton btn = (LinkButton)sender;
            string idEmpleado = btn.CommandArgument;

            Response.Redirect($"~/Contact.aspx?idEmpleado={idEmpleado}");*/
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
           /* LinkButton btn = (LinkButton)sender;
            string idEmpleado = btn.CommandArgument;

            bool respuesta = empleadoBL.Eliminar(Convert.ToInt32(idEmpleado));

            if (respuesta)
                MostrarEmpleados();*/
        }
    }
}