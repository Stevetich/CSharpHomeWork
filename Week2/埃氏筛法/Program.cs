using System;
using System.Collections;

namespace 埃氏筛法
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Calculate();
        }
    }

    class Calculator
    {
        ArrayList array = new ArrayList();
        public void Calculate()
        {
            for (int i = 2; i <= 100; i++)
            {
                array.Add(i);
            }

            int s = (int)Math.Ceiling(Math.Sqrt(101));
            //Console.WriteLine(s);
            //Console.WriteLine(array[0]);

            for (int i = 2; i <= s; i++)
            {
                if ((int)array[i - 2] != 0)
                {
                    int tem = i * i;
                    while (tem <= 100)
                    {
                        array[tem - 2] = 0;
                        tem += i;
                    }
                }
            }

            foreach (int ele in array) {
                if (ele != 0) Console.WriteLine(ele);
            }
        }

    }
}
