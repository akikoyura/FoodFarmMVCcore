using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFarmMVCcore.Models
{
    public class ProductOwnerRepository:IProductOwnerRepository
    {
        private DataContext context;
        public ProductOwnerRepository(DataContext ctx) => context = ctx;
        public IEnumerable<ProductOwner> ProductOwners => context.ProductOwners;
        public void AddProductOwner(ProductOwner productOwner)
        {
            context.ProductOwners.Add(productOwner);
            context.SaveChanges();
        }
        public void UpdateProductOwner(ProductOwner productOwner)
        {
            context.ProductOwners.Update(productOwner);
            context.SaveChanges();
        }
        public void DeleteProductOwner(ProductOwner productOwner)
        {
            context.ProductOwners.Remove(productOwner);
            context.SaveChanges();
        }

    }
}
