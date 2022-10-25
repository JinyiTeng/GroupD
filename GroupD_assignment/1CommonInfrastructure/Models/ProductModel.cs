﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; } // int
        public string ProductName { get; set; } // nvarchar(400)

        public string ProductCategory { get; set; }

        public String ProductQuantity { get; set; }

    }

}
