
namespace Grocery_Application
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.btnNewCustomer);
            this.panel1.Controls.Add(this.btnSearchCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.White;
            this.btnNewCustomer.Location = new System.Drawing.Point(378, 23);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(128, 37);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "Yeni";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Location = new System.Drawing.Point(221, 23);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(128, 37);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "Bul";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteriler";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GreenYellow;
            this.panel2.Controls.Add(this.btnNewProduct);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSearchProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 86);
            this.panel2.TabIndex = 0;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.White;
            this.btnNewProduct.Location = new System.Drawing.Point(378, 22);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(128, 37);
            this.btnNewProduct.TabIndex = 1;
            this.btnNewProduct.Text = "Yeni";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürünler";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.White;
            this.btnSearchProduct.Location = new System.Drawing.Point(221, 22);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(128, 37);
            this.btnSearchProduct.TabIndex = 1;
            this.btnSearchProduct.Text = "Bul";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.ForestGreen;
            this.panel3.Controls.Add(this.btnNewCategory);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSearchCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 86);
            this.panel3.TabIndex = 0;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.BackColor = System.Drawing.Color.White;
            this.btnNewCategory.Location = new System.Drawing.Point(378, 17);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(128, 37);
            this.btnNewCategory.TabIndex = 1;
            this.btnNewCategory.Text = "Yeni";
            this.btnNewCategory.UseVisualStyleBackColor = false;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kategoriler";
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.Color.White;
            this.btnSearchCategory.Location = new System.Drawing.Point(221, 17);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(128, 37);
            this.btnSearchCategory.TabIndex = 1;
            this.btnSearchCategory.Text = "Bul";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // grdCustomers
            // 
            this.grdCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCustomers.BackgroundColor = System.Drawing.Color.White;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCustomers.Location = new System.Drawing.Point(0, 258);
            this.grdCustomers.MultiSelect = false;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.ReadOnly = true;
            this.grdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers.Size = new System.Drawing.Size(1135, 264);
            this.grdCustomers.TabIndex = 1;
            this.grdCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellDoubleClick);
            // 
            // grdProducts
            // 
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.BackgroundColor = System.Drawing.Color.White;
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdProducts.Location = new System.Drawing.Point(0, 522);
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.ReadOnly = true;
            this.grdProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProducts.Size = new System.Drawing.Size(1135, 222);
            this.grdProducts.TabIndex = 2;
            this.grdProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellDoubleClick);
            // 
            // grdCategories
            // 
            this.grdCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCategories.BackgroundColor = System.Drawing.Color.White;
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategories.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdCategories.Location = new System.Drawing.Point(0, 744);
            this.grdCategories.MultiSelect = false;
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.ReadOnly = true;
            this.grdCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategories.Size = new System.Drawing.Size(1135, 164);
            this.grdCategories.TabIndex = 3;
            this.grdCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1135, 908);
            this.Controls.Add(this.grdCategories);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.grdCustomers);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uygulama Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.DataGridView grdCategories;
    }
}

