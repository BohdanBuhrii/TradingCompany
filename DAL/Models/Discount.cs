﻿using System;

namespace DAL.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PercentageSize { get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
    }
}
