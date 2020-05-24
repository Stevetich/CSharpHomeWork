using NewOrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class DetailForm : Form
    {
        public Order TempOrder { get; set; }
        public DetailForm()
        {
            InitializeComponent();
            customerBindingSource.Add(new Customer("张三"));
            customerBindingSource.Add(new Customer("王五"));

            goodBindingSource.Add(new Good("苹果", 5));
            goodBindingSource.Add(new Good("书", 15));
            goodBindingSource.Add(new Good("水杯", 8));
            goodBindingSource.Add(new Good("牛奶", 6));
        }

        //添加订单时调用
        public DetailForm(Order o, int orderID) : this()
        {
            TempOrder = o;
            //TempOrder的ID直接由OrderService记录的订单数来给定。
            TempOrder.OrderId = orderID;

            orderIDTextBox.Text = orderID.ToString();
            orderIDTextBox.Enabled = false;
            orderBindingSource.DataSource = TempOrder;
        }

        //修改订单时的调用
        public DetailForm(Order o) : this()
        {
            TempOrder = o;

            orderIDTextBox.Text = TempOrder.OrderId.ToString();
            orderIDTextBox.Enabled = false;
            orderBindingSource.DataSource = TempOrder;
        }

        private void addGoodBtn_Click(object sender, EventArgs e)
        {
            Good good = goodBindingSource.Current as Good;
            int num = (int)goodNum.Value;
            bool isExisted = false;

            //如果订单里没有商品，就直接添加进去。
            if (TempOrder.Items.Count == 0)
            {
                TempOrder.AddItem(good, num);
            }

            //如果订单中有商品，就看要添加的这个商品在不在订单里，如果在，就修改，不在就添加。
            for (int i = 0; i < TempOrder.Items.Count; i ++)
            {
                if (good.Name == TempOrder.Items[i].Name)
                {
                    TempOrder.Items[i].Num = num;
                    isExisted = true;
                }
            }
            if (!isExisted)
            {
                TempOrder.AddItem(good, num);
            }

            itemBindingSource.ResetBindings(false);
        }

        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            OrderItem item = itemBindingSource.Current as OrderItem;
            TempOrder.RemoveItem(item);
            itemBindingSource.ResetBindings(false);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //保存键保存后，设定顾客。
            TempOrder.Customer = customerBindingSource.Current as Customer;
            this.Close();
        }
    }
}
