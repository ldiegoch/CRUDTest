using CRUDTest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDTest.Repositories
{
    public class CategoryRepository : Repository
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

        public Category GetCategory(int id)
        {
            try
            {
                // We are retrieving data about a Category
                var cmd = new SqlCommand("SELECT  Id, Nombre, EsActiva FROM [co].[Categoria] WHERE Id = @id");
                cmd.Parameters.AddWithValue("id", id);
                return GetObject<Category>(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception("No pudimos cargar las Categorias", ex);
            }
        }

        public Boolean CreateCategory(Category category)
        {
            try
            {
                var cmd = new SqlCommand("[co].[Usp_Ins_Co_Categoria]");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("NombreCategoria", System.Data.SqlDbType.VarChar).Value = category.Name;
                cmd.Parameters.Add("EsActiva", System.Data.SqlDbType.Bit).Value = category.IsActive;
                return ExecProcedure(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("No pudimos crear la categoria: {0}", category.Name), ex);
            }
        }

        public Boolean DeleteCategory(int CategoryId)
        {
            try
            {
                var cmd = new SqlCommand("[co].[Usp_Del_Co_Categoria]");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("nIdCategori", System.Data.SqlDbType.Int).Value = CategoryId;
                return ExecProcedure(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("No pudimos borrar la categoria: {0}", CategoryId), ex);
            }
        }

        public Boolean UpdateCategory(Category category)
        {
            try
            {
                var cmd = new SqlCommand("[co].[Usp_Upd_Co_Categoria]");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("nIdCategori", System.Data.SqlDbType.Int).Value = category.Id;
                cmd.Parameters.Add("NombreCategoria", System.Data.SqlDbType.VarChar).Value = category.Name;
                cmd.Parameters.Add("EsActiva", System.Data.SqlDbType.Bit).Value = category.IsActive;
                return ExecProcedure(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("No pudimos actualizar la categoria: {0}", category.Name), ex);
            }
        }
    }
}