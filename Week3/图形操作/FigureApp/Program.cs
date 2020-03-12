using System;

namespace FigureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            factory.getShape(20);

           
        }
    }

    class Factory
    {
        public void getShape(int n)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Random random = new Random();
                int p = random.Next(1, 4);
                switch (p)
                {
                    case 1:
                        Triangle triangle = new Triangle(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
                        triangle.Show();
                        sum += triangle.getArea();
                        break;

                    case 2:
                        Square square = new Square(random.Next(1, 10));
                        square.Show();
                        sum += square.getArea();
                        break;

                    case 3:
                        Rectangle rectangle = new Rectangle(random.Next(1, 10), random.Next(1, 10));
                        rectangle.Show();
                        sum += rectangle.getArea();
                        break;
                }
            }
        }
    }

    abstract class Pologon
    {
        protected int edge; //边的数量
        protected double s = 0; //面积
        protected bool IsLegal; //合法性检测
        protected string name; //图形的名称

        
        public abstract void Judge();
        public abstract void Area();
        public double getArea()
        {
            return s;
        }

        //判断合法性并计算面积，展示
        public virtual void Show()
        {
            Judge();
            Area();
            if (IsLegal == true)
            {
                Console.WriteLine(name + "合法。");
                Console.WriteLine(name + "的面积为" + s);
            }
            else Console.WriteLine(name + "不合法！因此也无法计算面积！");
            Console.WriteLine();


        }
    }

    class Triangle : Pologon
    {
        int e1, e2, e3; //三条边
        
        public Triangle(int e1, int e2, int e3)
        {
            this.edge = 3; //边数为3
            this.e1 = e1;
            this.e2 = e2;
            this.e3 = e3;
            this.name = "三角形";
        }

        public override void Judge()
        {
            if ((e1 <= 0 || e2 <= 0 || e3 <= 0) || (e1 + e2 <= e3) || (e2 + e3 <= e1) || (e1 + e3 <= e2) )
            {
                IsLegal = false;
            }
            else
            {
                IsLegal = true;
            }
        }

        public override void Area()
        {
            Judge();
            if (IsLegal == true)
                s = Math.Sqrt((e1 + e2 + e3) * (e1 + e2 - e3) * (e1 + e3 - e2) * (e2 + e3 - e1));
        }

        public override void Show()
        {
            Console.WriteLine("该三角形的三边为" + e1 + "，" + e2 + "，" + e3 + "。");
            base.Show();
        }
    }

    class Square: Pologon
    {
        int len; //边长
        public Square(int e)
        {
            this.edge = 4; //边数为4
            this.len = e;
            this.name = "正方形";
        }

        //正方形只需判断边长是否不小于0
        public override void Judge()
        {
            if (len > 0) IsLegal = true;
            else IsLegal = false;
        }

        public override void Area()
        {
            Judge();
            if (IsLegal == true) s = len * len;
        }

        public override void Show()
        {
            Console.WriteLine("该正方形的边长为" + len + "。");
            base.Show();
        }
    }

    class Rectangle: Pologon
    {
        int e1, e2; //长方形只需要2条边就可以确定
        public Rectangle(int e1, int e2)
        {
            this.e1 = e1;
            this.e2 = e2;
            this.name = "长方形";
        }

        public override void Judge()
        {
            if (e1 > 0 && e2 > 0) IsLegal = true;
            else IsLegal = false;
        }

        public override void Area()
        {
            Judge();
            if (IsLegal) s = e1 * e2;
        }

        public override void Show()
        {
            Console.WriteLine("该长方形的边长为" + e1 + "和" + e2 + "。");
            base.Show();
        }
    }
}
