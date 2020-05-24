using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSerialize
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer()
        {

        }
        public Customer(string name) : this()
        {
            Name = name;
        }
    }
}
