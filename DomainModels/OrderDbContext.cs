using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<OrderDto> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderDto>()
                .HasData(
                 new OrderDto()
                 {
                     Id = 1,
                     DateCreated = new DateTime(2020, 1, 5),
                     ProductDescription = "Large Pizza with CocaCola",
                     DeliveryStatus = 3,
                     DeliveryDate = new DateTime(2020, 1, 5),
                     IsDeleted = false
                 },
                 new OrderDto()
                 {
                     Id = 2,
                     DateCreated = new DateTime(2020, 1, 6),
                     ProductDescription = "Large Pizza with CocaCola",
                     DeliveryStatus = 3,
                     DeliveryDate = new DateTime(2020, 1, 6),
                     IsDeleted = false
                 },
                 new OrderDto()
                 {
                     Id = 3,
                     DateCreated = new DateTime(2020, 1, 7),
                     ProductDescription = "Large Pizza with CocaCola",
                     DeliveryStatus = 2,
                     DeliveryDate = new DateTime(2020, 1, 7),
                     IsDeleted = false
                 },
                new OrderDto()
                {
                    Id = 4,
                    DateCreated = new DateTime(2020, 1, 8),
                    ProductDescription = "Large Pizza with CocaCola",
                    DeliveryStatus = 1,
                    DeliveryDate = new DateTime(2020, 1, 8),
                    IsDeleted = false
                });
        }
    }
}
