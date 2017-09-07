using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int z=0,w=0;
            int[] a = { 1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i < 10; i++)
            {
                if(a[i]%2==1)
                {
                    z += a[i];
                }
                if (a[i] % 2 == 0)
                {
                    w += a[i];
                }
            }
            Console.WriteLine("数组中奇数和是：" + z);
            Console.WriteLine("数组中偶数和是：" + w);
        }
    }
}
