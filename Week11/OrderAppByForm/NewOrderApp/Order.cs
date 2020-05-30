using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewOrderApp
{
	public class Order: IComparable<Order>
	{
		public List<OrderItem> Items { get; set; }

		[Key]
		public string OrderId { get; set; }
		public string CustomerID { get; set; }
		[ForeignKey("CustomerID")]
		public Customer Customer { get; set; }
		public string CustomerName
		{
			get => (Customer != null) ? Customer.Name : "";
		}
		public int TotalPrice
		{
			get => Items.Count == 0 ? 0 : Items.Sum(item => item.TotalPrice);
		}

		public Order()
		{
			OrderId = Guid.NewGuid().ToString();
			Items = new List<OrderItem>();
			Customer = new Customer();
		}

		public Order(Customer customer, List<OrderItem> items)
		{
			Customer = customer;
			if (items == null) Items = new List<OrderItem>();
			else Items = items;
		}

		public void AddItem(Good good, int num)
		{
			OrderItem item = new OrderItem(good, num);
			Items.Add(item);
		}

		public void RemoveItem(OrderItem orderItem)
		{
			Items.Remove(orderItem);
			//Count --;
		}

		public void RemoveItem(string id)
		{
			for (int i = 0; i < Items.Count; i ++)
			{
				if (Items[i].ID.ToString() == id)
				{
					Items.Remove(Items[i]);
					break;
				}
			}
			//Count --;
		}


		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"订单ID:{OrderId}  顾客:{CustomerName} 顾客ID：{Customer.ID}");
			stringBuilder.Append("\n货品ID  名称    数量");
			Items.ForEach(item => stringBuilder.Append("\n" + item));
			stringBuilder.Append("\n");
			return stringBuilder.ToString();
		}

		public override bool Equals(object obj)
		{
			var order = obj as Order;
			return order != null && OrderId == order.OrderId;
		}

		public int CompareTo(Order o)
		{
			if (o == null) return 1;
			return this.OrderId.CompareTo(o.OrderId);
		}

	}
}
