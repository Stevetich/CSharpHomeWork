using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrderAppWebAPI.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("orderDataBase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> OrderList { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Customer> CustomerList { get; set; }
    }
}