using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class CategoryGroup : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<CategoryGroupDiscount> CategoryGroupDiscounts { get; set; }
    }
}
