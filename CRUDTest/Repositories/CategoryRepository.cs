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

        public Boolean UpdateCategory(int CategoryId, string Name, bool isActive)
        {
            try
            {
                var cmd = new SqlCommand("[co].[Usp_Del_Co_Categoria]");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("nIdCategori", System.Data.SqlDbType.Int).Value = CategoryId;
                cmd.Parameters.Add("NombreCategoria", System.Data.SqlDbType.VarChar).Value = Name;
                cmd.Parameters.Add("nIdCategori", System.Data.SqlDbType.Bit).Value = isActive;
                return ExecProcedure(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("No pudimos actualizar la categoria: {0}", CategoryId), ex);
            }
        }
    }
}