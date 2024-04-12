using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    internal class Customer_Controller
    {
        //String connectionString;
        SqlDataAdapter? dataAdapter;
        BindingSource? bindingSource;
        public Customer_Controller() {
            //connectionString = "Data Source=MHK-SQL-ACTIVE;Initial Catalog=MANKO4;Persist Security Info=True;User ID=nflores";
            dataAdapter = new SqlDataAdapter();
            bindingSource = new BindingSource();
        }

        public DataTable GetData(string command)
        {
            //dataAdapter = new SqlDataAdapter(command, connection);
            String connectionString = "Data Source=MHK-SQL-ACTIVE;Initial Catalog=MANKO4;Persist Security Info=True";
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(command, connection);
                connection.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
    }
}
