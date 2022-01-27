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

    public partial class CustomerForm : Form
    {
        CustomerRepo customerRepo;
        ProductRepo productRepo;
        CategoryRepo categoryRepo;

        public CustomerForm()
        {
            InitializeComponent();

            customerRepo = new CustomerRepo();
            productRepo = new ProductRepo();
            categoryRepo = new CategoryRepo();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {           
            FillData();
        }

        Customer selectedCustomer = null;

        private void FillData()
        {
            try
            {
                int customerId = Convert.ToInt32(this.Tag);
                if (customerId > 0)
                {
                    var customer = customerRepo.GetById(customerId);
                    if (customer != null)
                    {
                        selectedCustomer = customer;

                        txtName.Text = customer.FirstName;
                        txtSurname.Text = customer.LastName;
                        txtPhone.Text = customer.Phone;
                        dtBirthDate.Value = customer.BirthDate.Value;
                        dtOrderDate.Value = customer.OrderDate.Date;
                        txtCountry.Text = customer.Country;
                        txtCity.Text = customer.City;
                        txtCounty.Text = customer.County;
                        txtAdress.Text = customer.Adress;
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
            this.Close();
        }

        private void FormSave()
        {
            if (this.selectedCustomer==null)
            {
                this.selectedCustomer = new Customer();
            }
            this.selectedCustomer.FirstName = txtName.Text;
            this.selectedCustomer.LastName = txtSurname.Text;
            this.selectedCustomer.Phone = txtPhone.Text;
            this.selectedCustomer.BirthDate = dtBirthDate.Value;
            this.selectedCustomer.OrderDate = dtOrderDate.Value;
            this.selectedCustomer.Country = txtCountry.Text;
            this.selectedCustomer.City = txtCity.Text;
            this.selectedCustomer.County = txtCounty.Text;
            this.selectedCustomer.Adress = txtAdress.Text;

            if (Convert.ToInt32(this.Tag)==0)
            {
                //insert işlemi
                this.selectedCustomer.CustomerID = customerRepo.Create(this.selectedCustomer);
                this.Tag = this.selectedCustomer.CustomerID;
            }
            else
            {
                //update işlemi
                customerRepo.Update(this.selectedCustomer);
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
            customerRepo.Delete(this.selectedCustomer);
        }
    }
}
