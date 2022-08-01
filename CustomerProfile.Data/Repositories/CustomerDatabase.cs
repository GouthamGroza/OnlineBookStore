using CustomerProfile.Data.Interfaces;
using CustomerProfile.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProfile.Data.Repositories
{
    public class CustomerDatabase : ICustomerRepository
    {
        private readonly CustomerDbContext _db;

        public CustomerDatabase(CustomerDbContext db)
        {
            _db = db;
        }

        public bool AddCustomer(CustomerDetail customer)
        {
            _db.CustomerDetails.Add(customer);
            _db.SaveChanges();
            return true;
        }

        public CustomerDetail GetCustomer(int id)
        {
            var customer = _db.CustomerDetails.FirstOrDefault(x=>x.CustomerId == id);
            return customer;
        }

        public List<CustomerDetail> GetCustomerDetails()
        {
            return _db.CustomerDetails.ToList();
        }

        public bool RemoveCustomer(int id)
        {
            var result = GetCustomer(id);
            if (result == null)
            {
                return false;
            }
            _db.CustomerDetails.Remove(result);
            _db.SaveChanges();
            return true;

        }
    }
}
