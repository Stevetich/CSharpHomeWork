using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewOrderApp
{
    public class OrderItem
    {
        public string Name {
            get => Good.Name;
        }

        public string GoodID { get; set; }
        [ForeignKey("GoodID")]
        public Good Good { get; set; }

        [Key]
        public string ID { get; set; }
        public int Price 
        {
            get => Good.Price;
        }

        public int Num { get; set; }
        public int TotalPrice { get => Num * Price; }

        public OrderItem()
        {
            ID = Guid.NewGuid().ToString();
            Good = new Good();
        }

        public OrderItem(Good good, int num) : this()
        {
            this.Good = good;
            this.GoodID = good.ID;
            this.Num = num;
        }

        public override string ToString()
        {
            return $"{ID}\t{Good.Name}\t{Num}";
        }
    }
}
