﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Admin.Clases
{
    public class Assortment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
        public int? IdBrand { get; set; }
    }
}
