﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Entities
{
    public class Product : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public required string Type { get; set; }
        public required string Brand { get; set; }
        public decimal StockQuantity { get; set; }
    }
    
}
