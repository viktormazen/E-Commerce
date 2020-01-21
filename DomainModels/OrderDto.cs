using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class OrderDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string ProductDescription { get; set; }
        public int DeliveryStatus { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDeleted { get; set; }

        //public OrderDto()
        //{

        //}
        //public OrderDto(int id, DateTime created, string productDescription)
        //{
        //    //if (id == null)
        //    //    throw new ArgumentNullException("id");
        //    this.Id = id;
        //    this.DateCreated = created;
        //    this.ProductDescription = productDescription;
        //}
    }

}
