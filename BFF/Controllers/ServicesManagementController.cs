using BFF.HttpHelpers;
using BFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace BFF.Controllers
{
    public class ServicesManagementController : ApiController
    {


        // Get Method for BookCatalog
        [HttpGet]

        [Route("books")]
        public  BookCatalog GetBookCatalog()
        {
            BookCatalog bookCatalog = null;

            return bookCatalog;

        }

        // Get Method for Customer Details
        [HttpGet]
        [Route("customers")]
        public CustomerDetails GetCustomerDetails()
        {
            var customerdetails = new CustomerDetails();
            return customerdetails;

        }
        [HttpGet]
        [Route("orders")]
        public OrderDetails GetOrderDetails()
        {
            OrderDetails orderDetails = new OrderDetails();
            return orderDetails;
        }
    }
}