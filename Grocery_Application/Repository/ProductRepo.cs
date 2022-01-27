using Grocery_Application.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Application.Repository
{
    public class ProductRepo : RepositoryBase, IRepository<Product>
    {
        //CustomerRepo da oluşturulan GetReader methoduna ulaşabilmek için implemente edildi.
        CustomerRepo customerRepo = new CustomerRepo();

        public int Create(Product item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Create_Update", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductName", item.ProductName);
                command.Parameters.AddWithValue("@CategoryId", item.CategoryID);
                command.Parameters.AddWithValue("@Unit", item.Unit);
                command.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                command.Parameters.AddWithValue("@UnitsInStock", item.UnitsInStock);

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

        public int Delete(Product item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", item.ProductID);
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

        public List<Product> Get()
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader = customerRepo.GetReader(command, "Sp_Products", this.Connection);
                while (reader.Read())
                {
                    var product = Mapping(reader);
                    products.Add(product);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return products;
        }

        public Product GetById(int ProductId)
        {
            Product product = null;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Products", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductId", ProductId);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    product = Mapping(reader);
                }

            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return product;
        }

        public Product Mapping(SqlDataReader reader)
        {
            Product product = new Product();
            product.ProductID = Convert.ToInt32(reader["ProductID"]);
            product.ProductName = reader["ProductName"].ToString();
            product.CategoryID = Convert.ToInt32(reader["CategoryID"]);
            product.Unit = reader["Unit"].ToString();
            product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
            product.UnitsInStock = Convert.ToInt16(reader["UnitsInStock"]);
            return product;

        }

        public int Update(Product item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Product_Create_Update", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("ProductId", item.ProductID);
                command.Parameters.AddWithValue("@ProductName", item.ProductName);
                command.Parameters.AddWithValue("@CategoryId", item.CategoryID);
                command.Parameters.AddWithValue("@Unit", item.Unit);
                command.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                command.Parameters.AddWithValue("@UnitsInStock", item.UnitsInStock);

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
    }
}
