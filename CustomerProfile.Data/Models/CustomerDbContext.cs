using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProfile.Data.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext() : base("name = CustomerDbContext")
        {

        }

        public DbSet<CustomerProfile.Data.Models.CustomerDetail> CustomerDetails { get; set; }
    }
}
