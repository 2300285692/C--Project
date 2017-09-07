using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入想要输入的行数：");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入想要输入的列数：");
            int y = int.Parse(Console.ReadLine());
            int[,] a = new int[x, y];
            int i, j,max,min,k,m=0;
            int r=0, l=0;//承载鞍点的行和列
            Console.WriteLine("请输入" + x + "行" + y + "列的数组：");
            for (i = 0; i < x; i++)
            {
                for (j = 0; j < y; j++)
                    a[i, j] = int.Parse(Console.ReadLine());
                if(j==5)
                    Console.WriteLine("\n");
            }
            for (i=0;i<x;i++)
            {
                for(j=0;j<y;j++)
                {
                    max = a[i, j];
                    min = a[i, j];
                    for(k=0;k<x;k++)
                        if (a[k, j] < min)
                        {
                           min = a[k, j];
                        }
                    for (k = 0; k < y; k++)
                        if (a[i, k] >max)
                        {
                            max = a[i, k];
                        }
                    if (a[i, j] == max && a[i, j] == min)
                    {
                        r = i;
                        l = j;
                        m = 1;
                    }
                }
            }
            if(m==1)
            {
                Console.WriteLine("鞍点是：" + a[r, l]);
            }
            if (m == 0)
            {
                Console.WriteLine("没有鞍点！");
            }
        }
    }
}
