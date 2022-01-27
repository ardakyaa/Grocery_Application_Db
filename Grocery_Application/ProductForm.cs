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
    using Repository;
    using Entities;

    public partial class ProductForm : Form
    {
        CustomerRepo customerRepo;
        ProductRepo productRepo;
        CategoryRepo categoryRepo;

        public ProductForm()
        {
            InitializeComponent();

            customerRepo = new CustomerRepo();
            productRepo = new ProductRepo();
            categoryRepo = new CategoryRepo();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            FillControl();
            FillData();
        }

        private void FillControl()
        {
            FillCategory();
        }

        private void FillCategory()
        {
            var categories = categoryRepo.Get();
            cmbCategoryName.DisplayMember = "CategoryName";
            cmbCategoryName.ValueMember = "CategoryID";
            cmbCategoryName.DataSource = categories;
        }

        Product selectedProduct = null;

        private void FillData()
        {
            try
            {
                int productId = Convert.ToInt32(this.Tag);
                if (productId > 0)
                {
                    var product = productRepo.GetById(productId);
                    if (product != null)
                    {
                        txtProductName.Text = product.ProductName;
                        cmbCategoryName.SelectedValue = product.CategoryID;
                        txtUnit.Text = product.Unit;
                        nuUnitPrice.Value = product.UnitPrice;
                        nuUnitsInStock.Value = product.UnitsInStock;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
            this.Close();
        }

        private void FormSave()
        {
            if (this.selectedProduct == null)
            {
                this.selectedProduct = new Product();
            }
            this.selectedProduct.ProductName = txtProductName.Text;
            this.selectedProduct.CategoryID = Convert.ToInt32(cmbCategoryName.SelectedValue);
            this.selectedProduct.Unit = txtUnit.Text;
            this.selectedProduct.UnitPrice = nuUnitPrice.Value;
            this.selectedProduct.UnitsInStock = Convert.ToInt16(nuUnitsInStock.Value);


            if (Convert.ToInt32(this.Tag) == 0)
            {
                //insert işlemi
                this.selectedProduct.ProductID = productRepo.Create(this.selectedProduct);
                this.Tag = this.selectedProduct.ProductID;
            }
            else
            {
                //update işlemi
                productRepo.Update(this.selectedProduct);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili müşteriyi silmek istiyor musunuz?", "Müşteri Ekranı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FormDelete();
                MessageBox.Show("Kayıt silme başarılı!");
                this.Close();
            }
        }

        private void FormDelete()
        {
            productRepo.Delete(this.selectedProduct);
        }
    }
}
