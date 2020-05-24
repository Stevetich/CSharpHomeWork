using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderSerialize
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();

            Customer zhang = new Customer("张三");
            Customer wang = new Customer("王五");

            Good apple = new Good("苹果", 5);
            Good book = new Good("书", 15);
            Good cup = new Good("水杯", 8);
            Good milk = new Good("牛奶", 6); 

            Order o1 = new Order(1, zhang, null);
            Order o2 = new Order(2, zhang, null);
            Order o3 = new Order(3, wang, null);

            o1.AddItem(apple, 15);
            o1.AddItem(cup, 3);

            o2.AddItem(apple, 20);
            o2.AddItem(book, 2);
            o2.AddItem(milk, 3);

            o3.AddItem(cup, 10);

            os.AddOrder(o2);
            os.AddOrder(o1);
            os.AddOrder(o3);
            os.Sort();

            Console.WriteLine("-----Export-----");
            os.Export(@"./OS.xml");
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----展示-----");
            Console.Write(os);
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----按ID查询-----");
            Console.Write(os.GetOrder(2));
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----按顾客查询-----");
            os.QueryByCustomerName("张三").ForEach(o => Console.Write(o));
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----删除订单-----");
            os.RemoveOrder(2);
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----展示-----");
            Console.Write(os);
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----Import-----");
            OrderService os2 = new OrderService();
            os2.Import(@"./OS.xml");
            os2.Orders.ForEach(o => Console.Write(o));
            Console.WriteLine("----------------");

            Console.ReadLine();
        }
    }

    public class OrderService
    {
        public List<Order> Orders { get; set; }
        
        public OrderService()
        {
            Orders = new List<Order>();
        }
        
        public Order GetOrder(int id)
        {
            Console.WriteLine($"获取第{id}号订单");
            return Orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void RemoveOrder(int id)
        {
            Order order = GetOrder(id);
            Console.WriteLine($"获取成功，已删除第{id}号订单");
            if (order != null) Orders.Remove(order);
        }

        public void UpdateOrder(Order o)
        {
            if (o != null)
            {
                RemoveOrder(o.OrderId);
                Orders.Add(o);
                Sort();
            }
        }

        public List<Order> QueryByCustomerName(string name)
        {
            Console.WriteLine($"获取顾客{name}的订单：");
            return Orders.
                Where(o => o.CustomerName == name).
                ToList();
        }

        public void Sort()
        {
            Orders.Sort((o1, o2) =>
            {
                if (o1.OrderId > o2.OrderId) return 1;
                else if (o1.OrderId == o2.OrderId) return 0;
                else return -1;
            });
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            Orders.ForEach(o => s.Append(o + "\n"));
            return s.ToString();
        }



        public void Export(string fn)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fileStream = new FileStream(fn, FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, Orders);
            }
        }

        public void Import(string fn)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fileStream = new FileStream(fn, FileMode.Open))
            {
                List<Order> tempOrderList = (List<Order>)xmlSerializer.Deserialize(fileStream);
                Orders.Clear();
                tempOrderList.ForEach(o => AddOrder(o));
            }
        }
    }
}
