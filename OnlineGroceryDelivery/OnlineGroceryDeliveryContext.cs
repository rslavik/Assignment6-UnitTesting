using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using OnlineGroceryDelivery.Models;

namespace OnlineGroceryDelivery
{
    public class OnlineGroceryDeliveryContext : DbContext
    {
        public OnlineGroceryDeliveryContext(DbContextOptions<OnlineGroceryDeliveryContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<DeliveryPerson> DeliveryPerson { get; set; }
    }
}
