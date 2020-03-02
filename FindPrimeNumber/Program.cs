﻿using System;
using System.Collections;

namespace FindPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(100);
            calculator.findPrime();
            calculator.findThePrimeFactor();
        }
    }

    class Calculator
    {
        int num;
        ArrayList array = new ArrayList();
        public Calculator(int num)
        {
            this.num = num;
        }

        public void findPrime ()
        {
            bool IsPrimeNumber = true;
            array.Add(2);
            if (num > 2)
            {
                for (int i = 2; i < num; i++)
                {
                    foreach (int ele in array)
                    {
                        //Console.WriteLine("ele is" + ele);
                        //Console.WriteLine("i is" + i);
                        if (i % ele == 0)
                        {
                            IsPrimeNumber = false;
                            break;
                        }
                    }
                    if (IsPrimeNumber)
                    {
                        array.Add(i);
                    }

                    IsPrimeNumber = true;

                }
            }
        }

        public void Show()
        {
            Console.WriteLine("All the prime numbers are:");
            foreach (int ele in array)
            {
                Console.WriteLine(ele);
            }
        }

        public void findThePrimeFactor()
        {
            while (true) 
            {
                foreach (int ele in array)
                {
                    if (num % ele == 0)
                    {
                        num = num / ele;
                        Console.WriteLine(ele);
                        break;
                    }
                }
                if (num == 1) break;
            }
           
        }
    }
}