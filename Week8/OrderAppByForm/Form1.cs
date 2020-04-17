using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using OrderAppByForm;

namespace OrderAppByForm
{
    public partial class Form1 : Form
    {
        public OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
            Order order1 = new Order("001");
            order1.AddItem(new Pen(5));
            order1.AddItem(new Bread(10));

            Order order2 = new Order("002");
            order2.AddItem(new Battery(50));
            order2.AddItem(new Bread(25));
            order2.AddItem(new Pen(1));

            Order order3 = new Order("003");
            order3.AddItem(new Pen(10));

            orderService.Add(order1);
            orderService.Add(order2);
            orderService.Add(order3);

            orderserBindingSource.DataSource = orderService.OrderList;
           //orderBindingSource.DataSource = OrderserDataGridView.CurrentRow.
        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            orderService.inquiryAll();
            Order order = orderserBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("还未选择订单");
            }
            orderService.Delete(order.OrderID);
            orderService.inquiryAll();
            
        }


        private void OrderserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(OrderserDataGridView.CurrentRow.Cells[1].Value);
            Console.WriteLine(orderBindingSource.Current);
            orderBindingSource.DataSource = orderserBindingSource.Current;
        }

        private void orderDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Hello!");
        }
    }
}
