using Example.Business.Abstract;
using Example.Business.Concrete;
using Example.Business.Utilities.DependencyResolver.Ninject;
using Example.Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.WindowsFormUI
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
            _iProductService = InstanceFactory.GetInstance<ProductManagement>();
            _iCategoryService = InstanceFactory.GetInstance<CategoryManagement>();
        }
        private IProductService _iProductService;
        private ICategoryService _iCategoryService;
        private void frmProduct_Load(object sender, EventArgs e)
        {
            FillCbxProductCategory();
            FillDgwProduct();
        }

        void FillDgwProduct()
        {
            dgwProduct.DataSource = _iProductService.FillDgwProduct();
        }
        void FillCbxProductCategory()
        {
            cbxAddProductCategory.DataSource = _iCategoryService.FillCbxProductCategory();
            cbxAddProductCategory.DisplayMember = "CategoryName";
            cbxAddProductCategory.ValueMember = "CategoryId";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtAddProduct.Text))
            {
                try
                {
                    _iProductService.AddProduct(new Product
                    {
                        ProductName = txtAddProduct.Text,
                        CategoryId = Convert.ToInt32(cbxAddProductCategory.SelectedValue)
                    });
                    FillCbxProductCategory();
                    FillDgwProduct();
                    MessageBox.Show("Data Saved");
                }
                catch  (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must fill all fields");
            }
        }
    }
}
