using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NewOrderApp
{
    class OrderContext : DbContext
    {
        public OrderContext() : base("orderDataBase") {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> OrderList { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Customer> CustomerList { get; set; }
    }
}
