﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FoodFarmMVCcore.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductOwner> ProductOwners { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

    }
}
