using CustomerProfile.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProfile.Data.Interfaces
{
    public interface ICustomerRepository
    {
        List<CustomerDetail> GetCustomerDetails();

        CustomerDetail GetCustomer(int id);

        bool AddCustomer(CustomerDetail customer);

        bool RemoveCustomer (int id);

    }
}
