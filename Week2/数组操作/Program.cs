using System;
using System.Collections;

namespace 数组操作
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Init();
            calculator.Show();
        }
    }

    class Calculator
    {
        ArrayList array = new ArrayList();

        public void Init()
        {
            Random ra = new Random();
            for (int i = 0; i < 20; i++)
            {
                array.Add(ra.Next(100));
            }
        }

        public void FindTheMax()
        {
            int max = 0;
            foreach (int e in array)
            {
                if (e > max)
                {
                    max = e;
                }
            }
            Console.WriteLine("The max number of the array is " + max + ".");
        }

        public void FindTheMin()
        {
            int min = 0;
            foreach (int e in array)
            {
                if (e > min)
                {
                    min = e;
                }
            }
            Console.WriteLine("The min number of the array is " + min + ".");
        }

        public int GetTheTotal()
        {
            int total = 0;
            foreach (int e in array)
            {
                total += e;
            }
            Console.WriteLine("The total of the array is " + total + ".");
            return total;
        }

        public void GetTheAverage()
        {
            double avge = 0;
            avge = GetTheTotal() / 20;
            Console.WriteLine("The average of the array is " + avge + ".");
        }

        public void Show()
        {
            Console.WriteLine("The array are:");
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
            FindTheMax();
            FindTheMin();
            GetTheTotal();
            GetTheAverage();
        }
    }
}