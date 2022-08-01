using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BFF.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public string BookName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }
    }
}