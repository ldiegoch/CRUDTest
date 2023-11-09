using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDTest.Models
{
    public class Product : DatabaseObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Product()
        {

        }

        public void LoadData(SqlDataReader reader)
        {
            this.Id = reader.GetInt32(0);
            this.Name = reader.GetString(1);
            this.Price = reader.GetDecimal(2);
            this.CategoryId = reader.GetInt32(3);
            this.CategoryName = reader.GetString(4);
        }
    }
}