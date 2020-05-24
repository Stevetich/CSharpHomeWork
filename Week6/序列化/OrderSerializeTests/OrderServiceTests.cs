using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSerialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSerialize.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os = new OrderService();
        
        Customer zhang = new Customer("张三");
        Customer wang = new Customer("王五");

        Good apple = new Good("苹果", 5);
        Good book = new Good("书", 15);
        Good cup = new Good("水杯", 8);
        Good milk = new Good("牛奶", 6);


        [TestInitialize]
        public void init()
        {
            Order o1 = new Order(1, zhang, null);
            Order o2 = new Order(2, zhang, null);
            Order o3 = new Order(3, wang, null);

            o1.AddItem(apple, 15);
            o1.AddItem(cup, 3);

            o2.AddItem(apple, 20);
            o2.AddItem(book, 2);
            o2.AddItem(milk, 3);

            o3.AddItem(cup, 10);

            os.AddOrder(o1);
            os.AddOrder(o2);
            os.AddOrder(o3);
        }

        [TestMethod()]
        public void GetOrderTest()
        {
            Order order = os.GetOrder(2);   

            Assert.AreEqual(order.OrderId, 2);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order o4 = new Order(4, zhang, null);
            o4.AddItem(apple, 5);
            os.AddOrder(o4);

            Assert.AreEqual(4, os.Orders.Count);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            os.RemoveOrder(2);

            Assert.AreEqual(2, os.Orders.Count);
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Order o3 = new Order(3, wang, null);
            o3.AddItem(cup, 10);
            o3.AddItem(book, 5);

            os.UpdateOrder(o3);

            Assert.AreEqual(2, os.GetOrder(3).Count);
        }

        [TestMethod()]
        public void QueryByCustomerNameTest()
        {
            List<Order> testOrders = os.QueryByCustomerName("张三");

            Assert.AreEqual(2, testOrders.Count);
        }

    }
}