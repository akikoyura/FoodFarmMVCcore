using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFarmMVCcore.Models
{
    public interface IProductOwnerRepository
    {
        IEnumerable<ProductOwner> ProductOwners { get;}
        void AddProductOwner(ProductOwner productOwner);
        void UpdateProductOwner(ProductOwner productOwner);
        void DeleteProductOwner(ProductOwner productOwner);

    }
}
