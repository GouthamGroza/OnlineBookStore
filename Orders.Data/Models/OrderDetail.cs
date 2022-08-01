using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public string BookName { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }


    }
}
