using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class ProductForm : Form
    {
        private readonly ProductViewModel _productViewModel;
        public ProductForm()
        {
            InitializeComponent();
            _productViewModel= new ProductViewModel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var productSaveDto = new ProductSaveDto()
            {
                Title = ProductTitleTxt.Text.ToString(),
                UnitPrice = Int32.Parse(ProductUnitPriceTxt.Text.ToString()),
            };
            _productViewModel.Save(productSaveDto);
            MessageBox.Show("Save Succesfully");
        }

        private void productRefresh_Click(object sender, EventArgs e)
        {
            productDvg.DataSource= _productViewModel.FillGrid();
        }

        private void ProductBackBtn_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(ProductDeletIdTxt.Text.ToString());
            var productDeleteDto = new ProductDeleteDto()
            {
                Id = id,
            };
            _productViewModel.Remove(productDeleteDto);
            MessageBox.Show("Deleted Successfully");
        }

        private void ProductUpdateBtn_Click(object sender, EventArgs e)
        {
            var productUpdateDto = new ProductUpdateDto()
            {
                Id = Int32.Parse(ProductNewIdTxt.Text.ToString()),
                Title = ProductNewTitleTxt.Text.ToString(),
                UnitPrice = Int32.Parse(ProductNewUnitPriceTxt.Text.ToString()),
            };
            _productViewModel.Update(productUpdateDto);
            MessageBox.Show("Updated succesfully!");
        }
    }
}
