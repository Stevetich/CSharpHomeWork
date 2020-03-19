using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            Random random = new Random();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(random.Next(1, 11));
            }

            intlist.ForEach(m => Console.WriteLine(m));

            int max = 0;
            intlist.ForEach(m => { if (m > max) max = m; });
            Console.WriteLine($"最大值为{max}");

            int min = int.MaxValue;
            intlist.ForEach(m => { if (m < min) min = m; });
            Console.WriteLine($"最小值为{min}");

            int sum = 0;
            intlist.ForEach(m => sum += m);
            Console.WriteLine($"总和为{sum}");

        }

        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }

            public Node(T t)
            {
                Next = null;
                Data = t;
            }
        }
        
        public class GenericList<T>
        {
            private Node<T> head;
            private Node<T> tail;

            public GenericList()
            {
                tail = head = null;
            }

            public Node<T> Head
            {
                get => head;
            }

            public void Add(T t)
            {
                Node<T> n = new Node<T>(t);
                if (tail == null)
                {
                    head = tail = n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }

            public void ForEach(Action<T> action)
            {
                Node<T> t = this.head;
                while (t != null)
                {
                    action(t.Data);
                    t = t.Next;
                }
            }

        }


    }
}
