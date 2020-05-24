﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrderApp
{
    public class Good
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Good()
        {

        }
        public Good(string name, int price) : this()
        {
            Name = name;
            Price = price;
        }
    }
}
