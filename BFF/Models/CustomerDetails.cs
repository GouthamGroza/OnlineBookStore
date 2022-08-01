using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFF.Models
{
    public class CustomerDetails
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
    }
}