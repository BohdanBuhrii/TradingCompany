using DAL.Models.Interfaces;
using System.Collections.Generic;

namespace DAL.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
    }
}
