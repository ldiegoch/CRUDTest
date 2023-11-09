using CRUDTest.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDTest.Repositories
{
    public class Repository
    {
        protected SqlConnection connection;

        public Repository()
        {
            string conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            this.connection = new SqlConnection(conexionString);
        }

        public List<T> GetList<T>(SqlCommand cmd) where T : DatabaseObject, new()
        {
            List<T> list = new List<T>();
            using (connection)
            {
                cmd.Connection = connection;
                connection.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    T obj = new T();
                    obj.LoadData(reader);
                    list.Add(obj);
                }
            }
            return list;
        }

        public bool ExecProcedure(SqlCommand cmd)
        {
            using (connection)
            {
                cmd.Connection = connection;
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}