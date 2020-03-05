using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        int addend1, addend2;

        int dividend, divisor;

        Random randomizer = new Random();
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            StartButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                StartButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
                if (timeLeft <= 5)
                    timeLabel.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is up.";
                MessageBox.Show("你没有完成训练，可惜。", "Fail");
                sum.Value = addend1 + addend2;
                StartButton.Enabled = true;
            }
        }

        //开始测验的方法
        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;
           
            divisor = randomizer.Next(2, 11);
            int tem = randomizer.Next(2, 11);
            dividend = tem * divisor;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;
            
            timeLeft = 10;
            timeLabel.Text = "10 seconds";
            timer1.Start();
        }

        private void answer_enter(object sender, EventArgs e)
        {
            NumericUpDown answerbox = sender as NumericUpDown;

            if (answerbox != null)
            {
                int lengthOfAnswer = answerbox.Value.ToString().Length;
                answerbox.Select(0, lengthOfAnswer);
            }
        }

        //检查答案是否正确
        public bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value)
                return true;
            else
                return false;
        }
    }
}
