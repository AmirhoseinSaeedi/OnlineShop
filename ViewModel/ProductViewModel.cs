using Model.Dtos;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;

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

        public void save (ProductSaveDto productSaveDto)
        {
            var product = new Product()
            {
                Title = productSaveDto.Title,
                UnitPrice = productSaveDto.UnitPrice,
            };
            _productService.Insert(product);
        }

        public void remove (ProductDeleteDto productDeleteDto)
        {
            var product = new Product()
            {
                Id = productDeleteDto.Id,
            };
            _productService.Delete(product);
        }
    }
}
