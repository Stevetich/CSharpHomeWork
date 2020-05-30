using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewOrderApp
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public Customer()
        {
            ID = Guid.NewGuid().ToString();
            Name = "";
        }
        public Customer(string name) : this()
        {
            Name = name;
        }
    }
}
