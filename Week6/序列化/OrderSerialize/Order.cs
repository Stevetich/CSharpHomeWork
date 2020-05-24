﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace OrderSerialize
{
	public class Order
	{
		public List<OrderItem> Items { get; set; }
		public int OrderId { get; set; }
		public Customer Customer { get; set; }
		public string CustomerName
		{
			get => Customer.Name;
		}
		public int Count { get; set; }

		public Order()
		{
			Items = new List<OrderItem>();
			Count = 0;
		}

		public Order(int orderid, Customer customer, List<OrderItem> items)
		{
			OrderId = orderid;
			Customer = customer;
			if (items == null) Items = new List<OrderItem>();
			else Items = items;

			Count = 0;
		}

		public void AddItem(Good good, int num)
		{
			Count ++;
			OrderItem item = new OrderItem(Count, good, num);
			Items.Add(item);
		}

		public void RemoveItem(OrderItem orderItem)
		{
			Items.Remove(orderItem);
		}

		public void RemoveItem(int id)
		{
			Items.ForEach(item =>
			{
				if (item.ID == id)
				{
					Items.Remove(item);
				}
			});
		}


		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append($"订单ID:{OrderId}  顾客:{CustomerName}");
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
