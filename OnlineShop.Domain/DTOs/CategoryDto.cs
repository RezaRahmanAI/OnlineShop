﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreateCategoryDto
    {
        public string Name { get; set; }
    }
}
