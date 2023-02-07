using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class ProductService
    {
        public List<Product> Select()
        {
            using (var context = new OnlineShopDbContex())
            {
                try
                {
                    var products = context.products.ToList();
                    return products;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(context != null)
                    { 
                        context.Dispose();
                    }
                }
            }
        }
    }
}
