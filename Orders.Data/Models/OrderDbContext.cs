using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext() : base("name = OrderDbContext")
        {

        }

        public DbSet<Orders.Data.Models.OrderDetail> OrderDetails { get; set; }
    }
}
