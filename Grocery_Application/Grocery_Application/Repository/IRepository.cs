using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Grocery_Application.Repository
{
    interface IRepository<T>
    {
        List<T> Get();
        T Mapping(SqlDataReader reader);
        T GetById(int id);
        int Create(T item);
        int Update(T item);
        int Delete(T item);
    }
}
