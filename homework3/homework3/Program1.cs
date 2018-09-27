using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    //创建工厂类
    class Factory
    {
        //静态工厂方法  
        public  Shape getProduct(String arg,double R)
        {
            Shape shape = null;
            if (arg == "A" )
            {
                shape = new Triangle(R);
                //初始化设置product  
                double area = shape.GetArea();
                Console.WriteLine("The area is" + area);
            }
            else if (arg == "B")
            {
                shape = new Square(R);
                //初始化设置product  
                double area = shape.GetArea();           
                Console.WriteLine("The area is" + area);
            }
            else if (arg == "C")
            {
                shape = new Rectangle(R);
                //初始化设置product  
                double area = shape.GetArea();
                Console.WriteLine("The area is" + area);
            }
            else if (arg == "D")
            {
                shape = new Circle(R);
                //初始化设置product  
                double area = shape.GetArea();
                Console.WriteLine("The area is" + area);
            }
            else
            {
                Console.WriteLine("请输入正确的选项");
            }
            return shape;
        }
    }
    //创建Shape类
    abstract class Shape
    {
        //成员变量
        public double R;
        public double area;

        //所有产品类的公共业务方法  
        public double getR()
        {
            //公共方法的实现  
            return R;
        }

        //声明抽象业务方法  
        public abstract double GetArea();
    }

    //创建三角形类
    class Triangle:Shape
    {
        //构造函数
        public Triangle(double R)
        {
            this.R = R;
        }
        //实现业务方法  
        public override double GetArea()
        {
            //业务方法的实现  
            area = 0.433 * R * R;
            return area;
        }
    }

    //创建正方形类
    class Square : Shape
    {
        //构造函数
        public Square(double R)
        {
            this.R = R;
        }
        //实现业务方法  
        public override double GetArea()
        {
            //业务方法的实现  
            area = R * R;
            return area;
        }
    }

    //创建长方形类
    class Rectangle : Shape
    {
        //构造函数
        public Rectangle(double R)
        {
            this.R = R;
        }
        //实现业务方法  
        public override double GetArea()
        {
            //业务方法的实现  
            area =  3 * R * R;
            return area;
        }
    }

    //创建圆形类
    class Circle : Shape
    {
        //构造函数
        public Circle(double R)
        {
            this.R = R;
        }
        //实现业务方法  
        public override double GetArea()
        {
            //业务方法的实现  
            area = R * R * 3.14;
            return area;
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请以字母形式输入你想创建的形状：A：三角形 B：正方形 C:长方形 D：圆形");
            string shape = Console.ReadLine();
            Console.WriteLine("请输入你想创建的形状的边长/直径");
            double R = Convert.ToDouble(Console.ReadLine());
            Factory factory = new Factory();
            factory.getProduct(shape,R);
            Console.ReadLine();
        }
    }
}
