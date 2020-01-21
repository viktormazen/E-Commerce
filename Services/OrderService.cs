using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using DomainModels;
using Models;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<OrderDto> _orderRepository;
        public OrderService(IRepository<OrderDto> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void CreateOrder(Order model)
        {
            
            var order = new OrderDto()
            {
                DateCreated = model.DateCreated,
                DeliveryDate = model.DeliveryDate,
                ProductDescription = model.ProductDescription,
                DeliveryStatus = (int)model.DeliveryStatus
            };
            _orderRepository.Add(order);
        }

        public void DeleteOrder(int id)
        {
            var item = _orderRepository.GetAll()
                .FirstOrDefault(x => x.Id == id);
            _orderRepository.Delete(item);
        }

        public List<Order> GetAllOrder()
        {
            return _orderRepository.GetAll()
                .Select(x => x.ToViewModel()).ToList();
        }

        public Order GetOrderById(int id)
        {
            var item = _orderRepository.GetAll()
                .FirstOrDefault(x => x.Id == id);
                return item.ToViewModel();
        }

        public List<Order> GetOrdersByDateRange(DateTime fromDate, DateTime toDate)
        {
            var item = _orderRepository.GetAll()
                .Where(x => x.DeliveryDate >= fromDate && x.DeliveryDate <= toDate).Select(x => x.ToViewModel()).ToList();
            return item;
        }
    }
}
