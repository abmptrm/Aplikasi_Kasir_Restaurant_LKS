using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kasir_Restaurant
{
    class Sqlserver
    {
        public SqlConnection getCon()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost; Initial Catalog=db_restaurant; Integrated Security=true";
            return con;
        }

    }
}
