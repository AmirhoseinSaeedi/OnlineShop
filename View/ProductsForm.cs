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
    public partial class ProductsForm : Form
    {
        private readonly ProductViewModel _productViewModel;
        public ProductsForm()
        {
            InitializeComponent();
            _productViewModel = new ProductViewModel();
        }

        private void ProductRefreshBtn_Click(object sender, EventArgs e)
        {
            ProductDVG.DataSource = _productViewModel.FillGrid();
        }

        private void ProductSaveBtn_Click(object sender, EventArgs e)
        {
            var productSaveDto = new ProductSaveDto()
            {
                Title = ProductTitleTxt.Text.ToString(),
                UnitPrice = Int32.Parse(ProductUnitPriceTxt.Text.ToString()),
            };
            _productViewModel.Save(productSaveDto);
            MessageBox.Show("Save Succesfully");
        }

        private void ProductDeleteBtn_Click(object sender, EventArgs e)
        {
            if (ProductDVG.DataSource != null)
            {
                var id = ProductDVG.CurrentRow.Cells[0].Value;
                var productDeleteDto = new ProductDeleteDto()
                {
                    Id = (int)id,
                };
                _productViewModel.Remove(productDeleteDto);
                MessageBox.Show("Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please select product you want to delete!!!");
            }
        }

        private void ProductUpdateBtn_Click(object sender, EventArgs e)
        {
            if(ProductDVG.DataSource != null)
            {
                var productUpdateDto = new ProductUpdateDto()
                {
                    Id = (int)ProductDVG.CurrentRow.Cells[0].Value,
                    Title = ProductTitleTxt.Text.ToString(),
                    UnitPrice = Int32.Parse(ProductUnitPriceTxt.Text.ToString()),
                };
                _productViewModel.Update(productUpdateDto);
                MessageBox.Show("Updated succesfully!");
            }
            else
            {
                MessageBox.Show("Please select product you want to update!!!");
            }
        }

        private void ProductBackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
