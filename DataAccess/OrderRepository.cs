using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class OrderRepository : IRepository<OrderDto>
    {
        private readonly OrderDbContext _context;
        public OrderRepository(OrderDbContext context)
        {
            _context = context;
        }

        public void Add(OrderDto entity)
        {
            _context.Orders.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(OrderDto entity)
        {
            _context.Orders.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<OrderDto> GetAll()
        {
            return _context.Orders.ToList();
        }

        public OrderDto GetById(int id)
        {
            return _context.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Update(OrderDto entity)
        {
            _context.Orders.Update(entity);
            _context.SaveChanges();
        }
    }
}
