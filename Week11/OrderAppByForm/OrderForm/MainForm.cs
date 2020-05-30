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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();

            //Customer zhang = new Customer("张三");
            //Customer wang = new Customer("王五");

            //Good apple = new Good("苹果", 5);
            //Good book = new Good("书", 15);
            //Good cup = new Good("水杯", 8);
            //Good milk = new Good("牛奶", 6);

            //Order o1 = new Order(zhang, null);
            //Order o2 = new Order(zhang, null);
            //Order o3 = new Order(wang, null);

            //o1.AddItem(apple, 15);
            //o1.AddItem(cup, 3);

            //o2.AddItem(apple, 20);
            //o2.AddItem(book, 2);
            //o2.AddItem(milk, 3);

            //o3.AddItem(cup, 10);

            //os.AddOrder(o1);
            //os.AddOrder(o2);
            //os.AddOrder(o3);

            orderBindingSource.DataSource = OrderService.GetOrderList();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            Console.WriteLine(order.OrderId);
            OrderService.RemoveOrder(order.OrderId);

            orderBindingSource.DataSource = OrderService.GetOrderList();
            orderBindingSource.ResetBindings(false);
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            DetailForm dForm = new DetailForm(new Order()); 
            if (dForm.ShowDialog() == DialogResult.OK)
            {
                OrderService.AddOrder(dForm.TempOrder);
            }

            orderBindingSource.DataSource = OrderService.GetOrderList();
            orderBindingSource.ResetBindings(false);
        }

        private void updateOrderBtn_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            DetailForm dForm = new DetailForm(order);
            if (dForm.ShowDialog() == DialogResult.OK)
            {
                OrderService.UpdateOrder(order);
            }

            orderBindingSource.DataSource = OrderService.GetOrderList();
            orderBindingSource.ResetBindings(false);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = saveFileDialog.FileName;
                OrderService.Export(fn);
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog.FileName;
                OrderService.Import(fn);

                orderBindingSource.DataSource = OrderService.GetOrderList();
                orderBindingSource.ResetBindings(false);
                OrderService.Sort();
            }
        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            switch (queryComboBox.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource = OrderService.GetOrderList();
                    break;
                case 1:
                    Order order = OrderService.GetOrder(queryTextBox.Text);
                    orderBindingSource.DataSource = order;
                    break;
                case 2:
                    List<Order> orders = OrderService.QueryByCustomerName(queryTextBox.Text);
                    orderBindingSource.DataSource = orders;
                    break;
            }

            orderBindingSource.ResetBindings(false);
        }

    }
}
