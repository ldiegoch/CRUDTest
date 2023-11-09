using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDTest.Models
{
    public class Category:DatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive {  get; set; }

        public void LoadData(SqlDataReader reader)
        {
            Id = reader.GetInt32(reader.GetOrdinal("Id"));
            Name = reader.GetString(reader.GetOrdinal("Nombre"));
            IsActive = reader.GetBoolean(reader.GetOrdinal("EsActiva"));
        }
    }
}