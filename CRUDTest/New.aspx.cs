using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CRUDTest.Repositories;
using CRUDTest.Models;

namespace CRUDTest
{
    public partial class New : System.Web.UI.Page
    {
        private CategoryRepository categoryRepository;

        public New() {
            categoryRepository = new CategoryRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["idCategory"] != null)
                {
                    int idCategory = Convert.ToInt32(Request.QueryString["idCategory"].ToString());

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
            Category categoria = new Category()
            {
                Id = Convert.ToInt32(categoryIdHidden.Value),
                Name = txtNombre.Text,
                IsActive = ckActiva.Checked,
            };

            bool respuesta;

            if (categoria.Id != 0)
                respuesta = categoryRepository.UpdateCategory(categoria);
            else
                respuesta = categoryRepository.CreateCategory(categoria);

            if (respuesta)
                Response.Redirect("~/Categories.aspx");
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('No se pudo realizar la operacion')", true);
        }

        private void loadCategory(int categoryId)
        {
            lblTitulo.Text = "Editar Categoria";
            btnSubmit.Text = "Actualizar";
            categoryIdHidden.Value = categoryId.ToString();

            Category category = categoryRepository.GetCategory(categoryId);
            txtNombre.Text = category.Name;
            ckActiva.Checked = category.IsActive;
        }

        private void prepareNewCategory()
        {
            lblTitulo.Text = "Nueva Categoria";
            btnSubmit.Text = "Guardar";
            categoryIdHidden.Value = "0";
        }
    }
}