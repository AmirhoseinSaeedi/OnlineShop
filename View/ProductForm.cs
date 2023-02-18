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
            _productViewModel.save(productSaveDto);
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
    }
}
