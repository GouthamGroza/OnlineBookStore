using CustomerProfile.Data.Interfaces;
using CustomerProfile.Data.Models;
using CustomerProfile.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Customers.Controllers
{
   
    public class CustomerController : ApiController
    {
        
        public ICustomerRepository _context;
      
        public CustomerController(ICustomerRepository context)
        {
            _context = context;
        }


        // GET api/values
        public IEnumerable<CustomerDetail> GetAllCustomers()
        {
            return _context.GetCustomerDetails();
        }

        // GET api/values/5
        public IHttpActionResult GetCustomerbyId(int id)
        {
            var customer = _context.GetCustomer(id);
            if (customer == null)
            {
                return NotFound();

            }
            return Ok(customer);
        }

        // POST api/values
        public IHttpActionResult PostCustomer(CustomerDetail customer)
        {
            if (_context.AddCustomer(customer))
            {
                return Ok(customer);

            }
            return BadRequest();
            
        }

        // DELETE api/values/5
        public IHttpActionResult DeleteCustomer(int id)
        {
            if (_context.RemoveCustomer(id))
            {
               return Ok(GetAllCustomers());
            }
            return NotFound();
        }
    }
}