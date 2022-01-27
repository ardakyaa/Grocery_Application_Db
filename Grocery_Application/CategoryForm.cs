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

    public partial class CategoryForm : Form
    {
        CategoryRepo categoryRepo;

        public CategoryForm()
        {
            InitializeComponent();

            categoryRepo = new CategoryRepo();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            try
            {
                int categoryId = Convert.ToInt32(this.Tag);
                if (categoryId > 0)
                {
                    var category = categoryRepo.GetById(categoryId);
                    if (category != null)
                    {
                        txtCategoryName.Text = category.CategoryName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Category selectedCategory = null;

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormSave();
            this.Close();
        }

        private void FormSave()
        {
            if(this.selectedCategory==null)
            {
                this.selectedCategory = new Category();
            }
            this.selectedCategory.CategoryName = txtCategoryName.Text;


            if (Convert.ToInt32(this.Tag) == 0)
            {
                //insert işlemi
                this.selectedCategory.CategoryID = categoryRepo.Create(this.selectedCategory);
                this.Tag = this.selectedCategory.CategoryID;
            }
            else
            {
                //update işlemi
                categoryRepo.Update(this.selectedCategory);
            }
        }
    }
}
