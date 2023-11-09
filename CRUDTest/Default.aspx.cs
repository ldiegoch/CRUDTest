using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUDTest.Repositories;
using CRUDTest.Models;
using WebGrease.Css.Ast.Selectors;

namespace CRUDTest
{
    public partial class _Default : Page
    {
        CategoryRepository categoryRepository;
        List<Category> categories { get; set; }

        public _Default() {
            categoryRepository = new CategoryRepository();
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categories = categoryRepository.GetCategories();
                Category firstCategory = categories[0];

                DropDownCategories.DataSource = categories;
                DropDownCategories.DataTextField = "Name";
                DropDownCategories.DataValueField = "Id";
                DropDownCategories.DataBind();

                LoadCategoryProducts(firstCategory.Id);
            }
        }

        protected void CategoryChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = Int32.Parse(DropDownCategories.SelectedItem.Value);
            LoadCategoryProducts(categoryId);
        }

        private void LoadCategoryProducts(int categoryId)
        {
            var productRepository = new ProductoRepositorio();
            List<Product> products = productRepository.GetProducts(categoryId);
            Products.DataSource = products;
            Products.DataBind();
        }
    }
}