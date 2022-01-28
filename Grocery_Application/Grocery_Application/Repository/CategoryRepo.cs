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
    public class CategoryRepo : RepositoryBase, IRepository<Category>
    {
        //CustomerRepo da oluşturulan GetReader methoduna ulaşabilmek için implemente edildi.
        CustomerRepo customerRepo = new CustomerRepo();


        public int Create(Category item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Category_Create_Update", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryName", item.CategoryName);

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

        public int Update(Category item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Category_Create_Update", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", item.CategoryID);
                command.Parameters.AddWithValue("@CategoryName", item.CategoryName);

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

        public int Delete(Category item)
        {
            int id = 0;
            try
            {
                SqlCommand command = new SqlCommand("Sp_Category_Delete", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", item.CategoryID);
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

        public List<Category> Get()
        {
            List<Category> categories = new List<Category>();
            try
            {
                SqlCommand command = new SqlCommand();
                SqlDataReader reader = customerRepo.GetReader(command, "Sp_Categories", this.Connection);
                while (reader.Read())
                {
                    var category = Mapping(reader);
                    categories.Add(category);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }
            return categories;
        }

        public Category GetById(int CategoryId)
        {
            Category category = null;

            try
            {
                SqlCommand command = new SqlCommand("Sp_Categories", this.Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CategoryId", CategoryId);
                if (this.Connection.State == ConnectionState.Closed) this.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    category = Mapping(reader);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open) this.Connection.Close();
            }

            return category;
        }

        public Category Mapping(SqlDataReader reader)
        {
            Category category = new Category();
            category.CategoryID= Convert.ToInt32(reader["CategoryID"]);
            category.CategoryName = reader["CategoryName"].ToString();
            return category;
        }

    }
}
