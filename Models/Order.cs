using System;

namespace Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string ProductDescription { get; set; }
        public DeliveryStatusEnum DeliveryStatus { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDeleted { get; set; }
    }

    public enum DeliveryStatusEnum
    {
        Created = 1, Posted = 2, Delivered = 3
    }
}
