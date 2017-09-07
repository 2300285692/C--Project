using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("请选择：（1.三角形  2.长方形）");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("请输入第一条边：");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第二条边：");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第三条边：");
                    int c = int.Parse(Console.ReadLine());
                    for (;;)
                    {
                        Console.WriteLine("请选择：（1.周长  2.面积 3.退出）");
                        int j = int.Parse(Console.ReadLine());
                        double l = a + b + c;
                        double p = l / 2;
                        if (j == 1)
                        {
                            Console.WriteLine("三角形的周长是：" + l);
                        }
                        if (j == 2)
                        {
                            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                            Console.WriteLine("三角形的面积是:" + s);
                        }
                        else
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("请输入长方形的长：");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入长方形的宽：");
                    int b = int.Parse(Console.ReadLine());
                    for (;;)
                    {
                        Console.WriteLine("请选择：（1.周长  2.面积 3.退出）");
                        int j = int.Parse(Console.ReadLine());
                        if (j == 1)
                        {
                            Console.WriteLine("长方形的周长是：" + (a + a + b + b));
                        }
                        if(j==2)
                        {
                            Console.WriteLine("长方形的面积是：" + (a * b));
                        }
                        else
                            break;
                    }
                }
            }
        }
    }
}
