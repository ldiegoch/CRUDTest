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
                LoadCategories();
            }
        }

        protected void LoadCategories()
        {
            var categoryRepository = new CategoryRepository();
            List<Category> categories = categoryRepository.GetCategories();
            CategoriesGrid.DataSource = categories;
            CategoriesGrid.DataBind();
        }

        protected void Editar_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            string idCategory = btn.CommandArgument;

            Response.Redirect($"~/New.aspx?idCategory={idCategory}");
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int idCategory = Convert.ToInt32(btn.CommandArgument);

            bool hasProducts = checkForAssociatedProducts(idCategory);

            if (hasProducts)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('La Categoria tiene productos asociados. Primero elimine los productos asociados.')", true);
            }
            else
            {
                bool respuesta = categoryRepository.DeleteCategory(idCategory);
                if (respuesta)
                {
                    LoadCategories();
                }
            }
        }

        protected bool checkForAssociatedProducts(int categoryId)
        {
            var productRepository = new ProductoRepositorio();
            List<Product> products = productRepository.GetProducts(categoryId);
            return products.Count > 0;
        }
    }
}