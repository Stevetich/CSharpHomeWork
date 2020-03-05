using System;

namespace CalculatorByConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            int answer;
            string opt;
            bool next = false;
            Console.WriteLine("欢迎来到计算器程序");
            while (!next)
            {
                try
                {
                    Console.WriteLine("请输入第一个数字：");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入第二个数字：");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    next = true;
                    Console.WriteLine("请输入计算符号：");
                    opt = Console.ReadLine();
                    
                    Calculator calculator = new Calculator(n1, n2, opt);
                    answer = calculator.Calculate();
                    Console.WriteLine("答案为" + answer);

                }
                catch (FormatException e)
                {
                    Console.WriteLine("请输入数字！");
                }
            }
        }
    }

    class Calculator
    {
        int n1, n2;
        int answer;
        string opt;
        public Calculator(int n1, int n2, string opt)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.opt = opt;
        }

        public int Calculate()
        {
            switch (opt)
            {
                case "+":
                    answer = n1 + n2;
                    break;

                case "-":
                    answer = n1 - n2;
                    break;

                case "*":
                    answer = n1 * n2;
                    break;

                case "/":
                    try
                    {
                        answer = n1 / n2;
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("不能除以0！");
                    }
                    break;
            }
            return answer;
        }

    }
}
