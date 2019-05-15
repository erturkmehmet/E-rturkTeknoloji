﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_rturkTeknoloji.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> products { get; set; }
    }
}