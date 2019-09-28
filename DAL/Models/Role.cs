using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
