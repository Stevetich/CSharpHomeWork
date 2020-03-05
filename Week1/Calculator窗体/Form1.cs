using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator窗体
{
    public partial class Form1 : Form
    {
        int n1, n2;
        int ans;
        string opt;
        public Form1()
        {
            InitializeComponent();
            comboBox.Items.Add("+");
            comboBox.Items.Add("-");
            comboBox.Items.Add("*");
            comboBox.Items.Add("/");

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException exp)
            {
                MessageBox.Show("请输入数字！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            opt = comboBox.Text;
            ans = Calculate();
            Answer.Text = ans.ToString();
        }

        private int Calculate()
        {
            switch (opt)
            {
                case "+": return n1 + n2; break;
                case "-": return n1 - n2; break;
                case "*": return n1 * n2; break;
                case "/": 
                    try
                    {
                        return n1 / n2;
                    }
                    catch (DivideByZeroException exp)
                    {
                        MessageBox.Show("不能除以0！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
            return 1;
        }
    }
}
