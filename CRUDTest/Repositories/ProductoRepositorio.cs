using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using WebGrease.Css.Ast.Selectors;
using CRUDTest.Models;
using System.Reflection;

namespace CRUDTest.Repositories
{
    public class ProductoRepositorio:Repository
    {
        public List<Product> GetProducts(int CategoryId)
        {
            try
            {
                var cmd = new SqlCommand("[co].[Usp_Sel_Co_Productos]");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("nIdCategori", System.Data.SqlDbType.Int).Value = CategoryId;
                return GetList<Product>(cmd);
            }
            catch(Exception ex)
            {
                throw new Exception("No pudimos cargar los Productos", ex);
            }
        } 
    }
}