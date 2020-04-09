using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            penComboBox.Items.Add("Blue");
            penComboBox.Items.Add("Red");
            penComboBox.Items.Add("Black");
            penComboBox.Items.Add("Orange");
            penComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = drawingPanel.CreateGraphics();
            else
            {
                graphics.Clear(this.BackColor);
            }
            n = Convert.ToInt32(nNumber.Value);
            leng = lengTrackBar.Value;
            th1 = th1TrackBar.Value / 16.0 * Math.PI / 180;
            th2 = th2TrackBar.Value / 16.0 * Math.PI / 180;
            per1 = per1TrackBar.Value / 10.0;
            per2 = per2TrackBar.Value / 10.0;
            drawCayleyTree(n, 200, 420, leng, -Math.PI /2);
        }

        private Graphics graphics;
        double leng = 100; //主干长度
        int n = 10; //递归深度
        double th1 = 30 * Math.PI /180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        //参数包括递归深度（n）、主干长度（leng）、右分支长度比（per1）、
        //左分支长度比（per2）、右分支角度（th1）、左分支角度（th2）、画笔颜色（pen）。
        public void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        public void drawLine(double x0, double y0, double x1, double y1)
        {
            string color = penComboBox.SelectedItem.ToString();
            Pen pen = new Pen(Color.Blue);
            switch (color)
            {
                case "Blue": pen.Color = Color.Blue; break;
                case "Red": pen.Color = Color.Red; break;
                case "Black": pen.Color = Color.Black; break;
                case "Orange": pen.Color = Color.Orange; break;
            }
            graphics.DrawLine(
               pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void lengTrackBar_Scroll(object sender, EventArgs e)
        {
            lengText.Text = lengTrackBar.Value.ToString();
        }

        private void per1TrackBar_Scroll(object sender, EventArgs e)
        {
            per1Text.Text = (per1TrackBar.Value / 10.0).ToString();
        }

        private void per2TrackBar_Scroll(object sender, EventArgs e)
        {
            per2Text.Text = (per2TrackBar.Value / 10.0).ToString();
        }

        private void th1TrackBar_Scroll(object sender, EventArgs e)
        {
            th1Text.Text = (th1TrackBar.Value / 16.0).ToString();
        }

        private void th2TrackBar_Scroll(object sender, EventArgs e)
        {
            th2Text.Text = (th2TrackBar.Value / 16.0).ToString();
        }
    }
}
