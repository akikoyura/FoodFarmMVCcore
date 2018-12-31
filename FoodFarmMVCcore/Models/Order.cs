using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFarmMVCcore.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime PurchaseDate { get; set; }
        public bool Shipped { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientPhoneNumber { get; set; }

        public IEnumerable<OrderLine> Lines { get; set; }
        //payment methods .....
        //Under development


    }
}
