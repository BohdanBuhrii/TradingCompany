﻿using System.Collections.Generic;

namespace DAL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
