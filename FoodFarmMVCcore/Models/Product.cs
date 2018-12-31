using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFarmMVCcore.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }

        public long ProductOwnerId { get; set; }
        public ProductOwner ProductOwners { get; set; }
        public double Unit { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public long SaleNumber { get; set; }
        public DateTime DateUpdate { get; set; }

        

    }
}
