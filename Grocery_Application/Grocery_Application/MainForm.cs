using Grocery_Application.Entities;
using Grocery_Application.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Application
{
    public partial class MainForm : Form
    {
        CustomerRepo customerRepo;
        ProductRepo productRepo;
        CategoryRepo categoryRepo;

        public MainForm()
        {
            InitializeComponent();

            customerRepo = new CustomerRepo();
            productRepo = new ProductRepo();
            categoryRepo = new CategoryRepo();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            FillGridCustomers();
        }

        private void FillGridCustomers()
        {
            grdCustomers.DataSource = customerRepo.Get();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            FillGridProducts();
        }

        private void FillGridProducts()
        {
            grdProducts.DataSource = productRepo.Get();
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            FillGridCategories();
        }

        private void FillGridCategories()
        {
            grdCategories.DataSource = categoryRepo.Get();
        }

        private void grdCustomers_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var customer = (grdCustomers.DataSource as List<Customer>)[e.RowIndex];
            CustomerForm form = new CustomerForm();
            form.Tag = customer.CustomerID;
            form.ShowDialog();
            FillGridCustomers();
        }

        private void grdProducts_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var product = (grdProducts.DataSource as List<Product>)[e.RowIndex];
            ProductForm form = new ProductForm();
            form.Tag = product.ProductID;
            form.ShowDialog();
            FillGridProducts();
        }

        private void grdCategories_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var category = (grdCategories.DataSource as List<Category>)[e.RowIndex];
            CategoryForm form = new CategoryForm();
            form.Tag = category.CategoryID;
            form.ShowDialog();
            FillGridCategories();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
            FillGridCustomers();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.ShowDialog();
            FillGridProducts();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm();
            form.ShowDialog();
            FillGridCategories();
        }

 
    }
}
