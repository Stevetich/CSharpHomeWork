using System;

namespace OrderItems
{
    public class OrderItem
    {
        public String name { get; set; } //货品的名字
        public int price { get; set; } //货品的价格
        public int num { get; set; } //货品的数量
        public String ID { get; set; } //货品的ID
        public int total; //总价格

        public override string ToString()
        {
            return ($"商品名称：{name}，商品ID为{ID}，商品价格：{price}，商品数量为{num}，商品总价为{total}元。\n");
        }

    }
    public class Bread : OrderItem
    {

        public Bread(int num) : base()
        {
            this.name = "面包";
            this.num = num;
            this.price = 20;
            this.total = 20 * num;
            this.ID = "I1";
        }
    }

    public class Battery : OrderItem
    {

        public Battery(int num) : base()
        {
            this.name = "电池";
            this.num = num;
            this.price = 15;
            this.total = 15 * num;
            ID = "I2";
        }
    }

    public class Pen : OrderItem
    {

        public Pen(int num) : base()
        {
            this.name = "钢笔";
            this.price = 30;
            this.num = num;
            this.total = 30 * num;
            ID = "I3";
        }
    }
}

