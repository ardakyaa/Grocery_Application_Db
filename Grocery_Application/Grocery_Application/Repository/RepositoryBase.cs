using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Application.Repository
{
    public abstract class RepositoryBase
    {
        SqlConnection connection = null;

        public RepositoryBase()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["GroceryDb"].ConnectionString);
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }

        }
    }
}
