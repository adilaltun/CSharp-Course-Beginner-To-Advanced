﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ProductManager : IProductManager
    {

        public void Add()
        {
            Console.WriteLine("Product Added.");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated.");
        }

    }
}
