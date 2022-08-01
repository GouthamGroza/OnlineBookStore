using Orders.Data.Interfaces;
using Orders.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Orders.Controllers
{
    public class OrdersController : ApiController
    {
        public IOrderRepository OrderRepository { get; set; }   
        public OrdersController(IOrderRepository context)
        {
            OrderRepository = context;
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return OrderRepository.GetAll();
        }

        public IHttpActionResult GetOrder(int id)
        {
            var order = OrderRepository.GetbyId(id);
            if(order == null)
            {
                return NotFound();
            }
            return Ok(order);
            
        }

        public IHttpActionResult AddOrders(OrderDetail orderDetail)
        {
            if (OrderRepository.AddOrder(orderDetail))
            {
                return Ok(OrderRepository);
            }
            return BadRequest();
        }

        public IHttpActionResult DeleteOrder (int id)
        {
            if (OrderRepository.Remove(id))
            {
                return Ok(GetOrderDetails());

            }
            return NotFound();
            
        }
    }
}