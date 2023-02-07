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

        }

        private void productRefresh_Click(object sender, EventArgs e)
        {
            productDvg.DataSource= _productViewModel.FillGrid();
        }
    }
}
