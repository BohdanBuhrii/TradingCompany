using DAL.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Discount : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PercentageSize { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<CategoryDiscount> CategoryDiscounts { get; set; }
        public virtual ICollection<CategoryGroupDiscount> CategoryGroupDiscounts { get; set; }
        public virtual ICollection<ProductDiscount> ProductDiscounts { get; set; }
    }
}
