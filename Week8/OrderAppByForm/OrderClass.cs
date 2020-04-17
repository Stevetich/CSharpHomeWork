using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace OrderAppByForm
{
    public class Order
    {
        public string OrderID { get; set; }
        public int TotalPrice { get; set; } //商品总金额
        //public ArrayList ItemsList = new ArrayList();
        private List<OrderItem> ItemsList;//商品列表

        public List<OrderItem> Items
        {
            get { return ItemsList; }
        }


        public Order(string id)
        {
            this.OrderID = id;
            Console.WriteLine($"创建{id}号订单");
            ItemsList = new List<OrderItem>();
        } 

        public void AddItem(OrderItem orderItem)
        {
            bool isexisted = true;
            if (ItemsList.Count == 0)
            {
                ItemsList.Add(orderItem);
                TotalPrice += orderItem.total;
            }
            else
            {
                foreach (OrderItem o in ItemsList)
                {
                    if (o.name.Equals(orderItem.name))
                    {
                        o.num += orderItem.num;
                        o.total += orderItem.total;
                    }
                    isexisted = false;
                }
                if (!isexisted)
                {
                    ItemsList.Add(orderItem);
                    TotalPrice += orderItem.total;
                }
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (OrderItem o in ItemsList)
            {
                s += o.ToString();
            }
            return ($"订单号为{OrderID}，总金额为{TotalPrice}元的订单：\n{s}");
        }
    }

    public class OrderService
    {
        public List<Order> OrderList = new List<Order> { };
        
        //添加一个订单
        public void Add(Order o)
        {
            OrderList.Add(o);
        }

        public void Sort()
        {
            //通过Lambda表达式进行排序
            OrderList.Sort((o1, o2) => o1.TotalPrice - o2.TotalPrice);
        }

        public void Delete(string id)
        {
            Console.WriteLine("--------删除订单--------");
            bool deleted = false;
            if (OrderList.Count == 0)
            {
                Console.WriteLine("暂无可选订单！");
            }
            else
            {
                for (int i = 0; i < OrderList.Count; i ++){
                    Order o = OrderList[i];
                    if (o.OrderID.Equals(id))
                    {
                        OrderList.Remove(o);
                            Console.WriteLine($"已删除{id}号订单\n");
                    }
                    deleted = true;
                }
                if (!deleted)
                {
                    Console.WriteLine("未找到对应订单！");
                }
            }
        }

        public void inquiryByID(String id)
        {
            var query = from order in OrderList where order.OrderID.Equals(id) select order;
            Console.WriteLine("--------查询ID--------");
            if (query.Count<Order>() == 0)
            {
                Console.WriteLine("暂无可查看订单！");
            }
            else
            {
                foreach (Order o in query)
                {
                    Console.WriteLine(o);
                }
            }
        }

        public void inquiryAll()
        {
            var query = from order in OrderList orderby order.TotalPrice descending select order;
            Console.WriteLine("--------查询所有--------");
            foreach (Order o in query)
            {
                Console.WriteLine(o);
            }
        }


        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = File.Create(@"C:\Users\Administrator\Desktop\test.xml"))
            {
                xmlSerializer.Serialize(fs, OrderList);
            }
        }


        public void Inport()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = File.OpenRead(@"C:\Users\Administrator\Desktop\test.xml"))
            {
                OrderList = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }

    }

    public class Factory
    {
        public void Start()
        {
            //OrderItem a = new Battery(20);
            //OrderItem b = new Bread(10);
            //OrderItem c = new Pen(5);

            Order order1 = new Order("001");
            order1.AddItem(new Pen(5));
            order1.AddItem(new Bread(10));

            Order order2 = new Order("002");
            order2.AddItem(new Battery(50));
            order2.AddItem(new Bread(25));
            order2.AddItem(new Pen(1));

            Order order3 = new Order("003");
            order3.AddItem(new Pen(10));

            OrderService os = new OrderService();
            os.Add(order1);
            os.Add(order2);
            os.Add(order3);
            os.Sort();
            os.inquiryAll();
            os.inquiryByID("002");


            os.Delete("003");
            os.inquiryAll();
        }
    }

}
