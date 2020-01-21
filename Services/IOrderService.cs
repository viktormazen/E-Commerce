using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IOrderService
    {
        void CreateOrder(Order model);
        Order GetOrderById(int id);
        List<Order> GetOrdersByDateRange(DateTime fromDate, DateTime toDate);
        List<Order> GetAllOrder();
        void DeleteOrder(int id);
    }
}
