using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoodFarmMVCcore.Models
{
    public class ProductRepository:IProductRepository
    {
        private DataContext context;
        public ProductRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Product> Products => context.Products.Include(p => p.Category).ToArray();
        public Product GetProduct(long key) => context.Products.Include(p => p.Category).First(p => p.Id == key);
        
        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }


    }
}
