using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDTest.Models
{
    public interface DatabaseObject
    {
        void LoadData(SqlDataReader reader);
    }
}