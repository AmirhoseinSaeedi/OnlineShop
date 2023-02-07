using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProductViewModel
    {
        private readonly ProductService _productService;

        public ProductViewModel()
        {
            _productService = new ProductService();
        }

        public dynamic FillGrid()
        {
            return _productService.Select();
        }
    }
}
