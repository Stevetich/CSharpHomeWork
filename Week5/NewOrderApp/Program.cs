using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewOrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //初始化
            OrderService os = new OrderService();

            Customer zhang = new Customer("张三");
            Customer wang = new Customer("王五");

            Good apple = new Good("苹果", 5);
            Good book = new Good("书", 15);
            Good cup = new Good("水杯", 8);
            Good milk = new Good("牛奶", 6); 

            Order o1 = new Order(zhang, null);
            Order o2 = new Order(zhang, null);
            Order o3 = new Order(wang, null);

            o1.AddItem(apple, 15);
            o1.AddItem(cup, 3);

            o2.AddItem(apple, 20);
            o2.AddItem(book, 2);
            o2.AddItem(milk, 3);

            o3.AddItem(cup, 10);

            //打乱顺序后os可以按照订单号排序
            os.AddOrder(o2);
            os.AddOrder(o1);
            os.AddOrder(o3);
            os.Sort();

            Console.WriteLine("-----展示-----");
            Console.Write(os);
            Console.WriteLine("----------------");
            Console.WriteLine();

            //查找订单ID为2的订单
            Console.WriteLine("-----按ID查询-----");
            Console.Write(os.GetOrder(2));
            Console.WriteLine("----------------");
            Console.WriteLine();

            //查找顾客张三的所有订单
            Console.WriteLine("-----按顾客查询-----");
            os.QueryByCustomerName("张三").ForEach(o => Console.Write(o));
            Console.WriteLine("----------------");
            Console.WriteLine();

            //删除2号订单
            Console.WriteLine("-----删除订单-----");
            os.RemoveOrder(2);
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.WriteLine("-----展示-----");
            Console.Write(os);
            Console.WriteLine("----------------");
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class OrderService
    {
        public List<Order> orders { get; set; }
        public int Count { get; set; }


        
        public OrderService()
        {
            orders = new List<Order>();
            Count = 0;
        }
        
        public Order GetOrder(int id)
        {
            Console.WriteLine($"获取第{id}号订单");
            return orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            Count ++;
            order.OrderId = Count;
            orders.Add(order);
        }

        public void UpdateOrder(Order o)
        {
            if (o != null)
            {
                RemoveOrder(o.OrderId);
                orders.Add(o);
                Sort();
            }
        }

        public void RemoveOrder(int id)
        {
            Order order = GetOrder(id);
            Console.WriteLine($"获取成功，已删除第{id}号订单");
            orders.Remove(order);
        }

        public void RemoveOrder(Order o)
        {
            orders.Remove(o);
        }
        public List<Order> QueryByCustomerName(string name)
        {
            Console.WriteLine($"获取顾客{name}的订单：");
            return orders.
                Where(o => o.CustomerName == name).
                ToList();
        }

        public void Sort()
        {
            orders.Sort((o1, o2) =>
            {
                if (o1.OrderId > o2.OrderId) return 1;
                else if (o1.OrderId == o2.OrderId) return 0;
                else return -1;
            });
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            orders.ForEach(o => s.Append(o + "\n"));
            return s.ToString();
        }

    }
}
