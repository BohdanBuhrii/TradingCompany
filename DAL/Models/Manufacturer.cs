using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Manufacturer : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
