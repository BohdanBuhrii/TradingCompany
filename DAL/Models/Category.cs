using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public int? CategoryGroupId { get; set; }

        public virtual CategoryGroup CategoryGroup { get; set; }
        public virtual ICollection<CategoryDiscount> CategoryDiscounts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
