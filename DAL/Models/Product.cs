using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? CategoryId { get; set; }
        public int? CustomerId { get; set; }
        public int? ManufacturerId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
    }
}
