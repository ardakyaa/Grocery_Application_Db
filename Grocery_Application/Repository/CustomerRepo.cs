using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Application.Repository
{
    using Entities;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public class CustomerRepo : RepositoryBase, IRepository<Customer>
    {

        public int Create(Customer item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Create_Update", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@OrderDate", item.OrderDate);
                command.Parameters.AddWithValue("@Adress", item.Adress);
                command.Parameters.AddWithValue("@Phone", item.Phone);
                command.Parameters.AddWithValue("@City", item.City);
                command.Parameters.AddWithValue("@County", item.County);
                command.Parameters.AddWithValue("@Country", item.Country);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return id;
        }

        public int Delete(Customer item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId",item.CustomerID);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                command.ExecuteNonQuery();
                id = Convert.ToInt32(command.ExecuteNonQuery());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return id;
        }

        public List<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader = GetReader(command, "Sp_Customers", this.Connection);
                while (reader.Read())
                {
                    var customer = Mapping(reader);
                    customers.Add(customer);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return customers;
        }

        public SqlDataReader GetReader(SqlCommand command, string procedure, SqlConnection con)
        {
            command = new SqlCommand(procedure, con);
            command.CommandType = CommandType.StoredProcedure;
            if (con.State == ConnectionState.Closed) con.Open();
            SqlDataReader reader = command.ExecuteReader();
            return reader;

        }

        public Customer GetById(int CustomerId)
        {
            Customer customer = null;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Customers", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId", CustomerId);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    customer = Mapping(reader);
                }

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return customer;
        }

        public int Update(Customer item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Customer_Create_Update", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CustomerId", item.CustomerID);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@BirthDate", item.BirthDate);
                command.Parameters.AddWithValue("@OrderDate", item.OrderDate);
                command.Parameters.AddWithValue("@Adress", item.Adress);
                command.Parameters.AddWithValue("@Phone", item.Phone);
                command.Parameters.AddWithValue("@City", item.City);
                command.Parameters.AddWithValue("@County", item.County);
                command.Parameters.AddWithValue("@Country", item.Country);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return id;
        }

        public Customer Mapping(SqlDataReader reader)
        {
            Customer customer = new Customer();
            customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
            customer.FirstName = reader["FirstName"].ToString();
            customer.LastName = reader["LastName"].ToString();
            customer.BirthDate = Convert.ToDateTime(reader["BirthDate"]);
            customer.OrderDate= Convert.ToDateTime(reader["OrderDate"]);
            customer.Adress = reader["Adress"].ToString();
            customer.Phone = reader["Phone"].ToString();
            customer.City = reader["City"].ToString();
            customer.Country = reader["County"].ToString();
            customer.Country = reader["Country"].ToString();
            return customer;
        }
    }
}
