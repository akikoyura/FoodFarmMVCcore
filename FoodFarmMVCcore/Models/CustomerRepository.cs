using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodFarmMVCcore.Models
{
    public class CustomerRepository:ICustomerRepository
    {
        DataContext context;
        CustomerRepository(DataContext ctx) => context = ctx;
        public IEnumerable<Customer> Customers => context.Customers;

        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }
        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
        public void DeleteCustomer(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }


    }
}
