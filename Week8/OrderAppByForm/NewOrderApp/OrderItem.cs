using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOrderApp
{
    public class OrderItem
    {
        public string Name {
            get => Good.Name;
        }

        public Good Good { get; set; }
        public int ID { get; set; }
        public int Price 
        {
            get => Good.Price;
        }

        public int Num { get; set; }
        public int TotalPrice { get => Num * Price; }

        public OrderItem()
        {

        }

        public OrderItem(int ID, Good good, int num) : this()
        {
            this.ID = ID;
            this.Good = good;
            this.Num = num;
        }

        public override string ToString()
        {
            return $"{ID}\t{Good.Name}\t{Num}";
        }
    }
}
