using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实训2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //正方形
            Square s = new Square();
            s.initialize();
            s.getPerimeter();
            s.getArea();
            s.result();

            //圆形
            Circle c = new Circle();
            c.initialize();
            c.getPerimeter();
            c.getArea();
            c.result();
        }
    }

    interface IShape
    {
        decimal initialize();
        decimal getPerimeter();
        decimal getArea();
    }
    public interface IDisplayResult
    {
        void result();
    }
    public class Square : IShape, IDisplayResult
    {
        public decimal a; //边长
        public decimal zhouchang;
        public decimal area;
        public decimal initialize()
        {
            a = 0;
            return a;
        }
        public decimal getPerimeter()
        {
            Console.WriteLine("请输入正方形边长：");
            a = decimal.Parse(Console.ReadLine());
            return a;
        }
        public decimal getArea()
        {
            zhouchang = 4 * a;
            area = a * a;
            return area;
        }
        public void result()
        {
            Console.WriteLine("周长为：" + zhouchang);
            Console.WriteLine("面积为：" + area);
        }
    }
    public class Circle : IShape, IDisplayResult
    {
        public decimal r; //半径
        public decimal zhouchang;
        public decimal area;
        public decimal initialize()
        {
            r = 0;
            return r;
        }
        public decimal getPerimeter()
        {
            Console.WriteLine();
            Console.WriteLine("请输入圆形半径：");
            r = decimal.Parse(Console.ReadLine());
            return r;
        }
        public decimal getArea()
        {
            zhouchang = 2 * 3 * r;
            area = 3 * r * r;
            return area;
        }
        public void result()
        {
            Console.WriteLine("周长为：" + zhouchang);
            Console.WriteLine("面积为：" + area);
        }
    }
}
