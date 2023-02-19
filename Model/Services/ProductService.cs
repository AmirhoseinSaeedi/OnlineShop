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

        public void Insert(Product product)
        {
            using (var context = new OnlineShopDbContex())
            {
                try
                {
                    context.products.Add(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally { 
                    if(context != null) {
                        context.Dispose();
                    }
                }
            }
        }

        public void Delete(Product product)
        {
            using(var context = new OnlineShopDbContex())
            {
                try
                {
                    var manufacture = context.products.Where(m => m.Id == product.Id).First();
                    context.products.Remove(manufacture);
                    context.SaveChanges();
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

        public void Update(Product product)
        {
            using(var context = new OnlineShopDbContex())
            {
                try
                {
                    var manufacture = context.products.Where(m => m.Id== product.Id).First();
                    manufacture.Title = product.Title;
                    manufacture.UnitPrice = product.UnitPrice;
                    context.SaveChanges();
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
