using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public static class ModelMapper
    {
        public static Order ToViewModel (this OrderDto model)
        {
            return new Order
            {
                Id = model.Id,
                DateCreated = model.DateCreated,
                DeliveryDate = model.DeliveryDate,
                IsDeleted = model.IsDeleted,
                ProductDescription = model.ProductDescription,
                DeliveryStatus = (DeliveryStatusEnum)model.DeliveryStatus
            };
        }
    }
}
