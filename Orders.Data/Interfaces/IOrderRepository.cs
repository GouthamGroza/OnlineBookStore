using Orders.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Data.Interfaces
{
    public interface IOrderRepository
    {
        bool AddOrder(OrderDetail orderDetail);

        List<OrderDetail> GetAll();

        OrderDetail GetbyId(int id);

        bool Remove(int id);
    }
}
