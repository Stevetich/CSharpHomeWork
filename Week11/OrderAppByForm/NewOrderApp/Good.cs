using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewOrderApp
{
    public class Good
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Good()
        {
            ID = Guid.NewGuid().ToString();
            Name = "";
            Price = 0;
        }
        public Good(string name, int price) : this()
        {
            Name = name;
            Price = price;
        }
    }
}
