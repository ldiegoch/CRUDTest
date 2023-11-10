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

        protected void ToggleForm(bool visibility)
        {
            FormPanel.Visible = visibility;
            BtnCreate.Visible = !visibility;
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
            categoryIdHidden.Value = idCategory;
            lblTitulo.Text = "Editar Categoría";
            loadCategory(Convert.ToInt32(idCategory));
            ToggleForm(true);
        }

        protected void Eliminar_Click(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int idCategory = Convert.ToInt32(btn.CommandArgument);

            bool hasProducts = checkForAssociatedProducts(idCategory);

            if (hasProducts)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Esta categoria tiene productos asociados y no puede ser borrada.')", true);
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
            {
                ToggleForm(false);
                LoadCategories();
            }
            else
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('No se pudo realizar la operacion')", true);
        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            categoryIdHidden.Value = "0";
            lblTitulo.Text = "Crear Categoría";
            ToggleForm(true);
        }

        private void loadCategory(int categoryId)
        {
            btnSubmit.Text = "Actualizar";
            categoryIdHidden.Value = categoryId.ToString();

            Category category = categoryRepository.GetCategory(categoryId);
            txtNombre.Text = category.Name;
            ckActiva.Checked = category.IsActive;
        }
    }
}