using CRUDTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDTest.Repositories
{
    public class CategoryRepository:Repository
    {
        public List<Category> GetCategories()
        {
            try
            {
                // We are retrieving data from a view
                var cmd = new SqlCommand("SELECT  Id, Nombre, EsActiva FROM [co].[Categoria]");
                return GetList<Category>(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("No pudimos cargar las Categorias", ex);
            }
        }
    }
}