using Orders.Data.Interfaces;
using Orders.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Repositories
{
    public class OrderDatabase : IOrderRepository

    {

        private readonly OrderDbContext _db;
        public OrderDatabase(OrderDbContext db)
        {
            _db = db;
        }
        public bool AddOrder(OrderDetail orderDetail)
        {
            _db.OrderDetails.Add(orderDetail);
            _db.SaveChanges();
            return true;
        }

        public OrderDetail GetbyId(int id)
        {
            return _db.OrderDetails.FirstOrDefault(x => x.OrderId == id);
        }

        public List<OrderDetail> GetAll()
        {
            return _db.OrderDetails.ToList();
        }

        public bool Remove(int id)
        {
            var order = GetbyId(id);
            if (order == null)
            {
                return false;
            }
            _db.OrderDetails.Remove(order);
            _db.SaveChanges();
            return true;
        }

        
    }
}
